using System;
using System.Collections.Generic;
using System.Linq;
using IO_Project.Core.Analysis.Models;
using IO_Project.Input;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Msagl.Drawing;

namespace IO_Project.Core.Analysis {
    public class SourceSemanticAnalyzer {
        private Dictionary<string, SourceNamespace> _namespacesByName;
        private Dictionary<string, SourceFile> _filesByIdentifier;
        private Dictionary<string, SourceMethod> _methodsBySemanticName;
        private Dictionary<string, SourceClass> _classesByName;

        private Dictionary<string, SyntaxTree> _syntaxTrees = new Dictionary<string, SyntaxTree>();
        private CSharpCompilation _compilation;

        public SourceAnalysisModel Analyze(List<InputFile> inputFiles) {
            ClearState();

            AccumulateSyntaxTrees(inputFiles);
            CompileProject();

            //first iteration
            foreach (var inputFile in inputFiles) {
                try {
                    AggregateSourceSymbols(inputFile);
                } catch (Exception e) {
                }
            }


            foreach (var inputFile in inputFiles) {
                try {
                    FindSourceRelations(inputFile);
                } catch (Exception e) {
                }
            }

            return new SourceAnalysisModel {
                CurrentCommitHash = "#hash", //todo!
                Files = _filesByIdentifier,
                Namespaces = _namespacesByName
            };
        }


        private void ClearState() {
            _namespacesByName = new Dictionary<string, SourceNamespace>();
            _filesByIdentifier = new Dictionary<string, SourceFile>();
            _methodsBySemanticName = new Dictionary<string, SourceMethod>();
            _classesByName = new Dictionary<string, SourceClass>();
            _syntaxTrees = new Dictionary<string, SyntaxTree>();
        }


        private void AccumulateSyntaxTrees(List<InputFile> inputFiles) {
            foreach (var inputFile in inputFiles) {
                GetSyntaxTree(inputFile);
            }
        }

        private void FindSourceRelations(InputFile inputFile) {
            var tree = GetSyntaxTree(inputFile);
            var root = (CompilationUnitSyntax) tree.GetRoot();

            if (!_filesByIdentifier.ContainsKey(inputFile.RelativePath)) return;

            var sourceFile = _filesByIdentifier[inputFile.RelativePath];

            var model = _compilation.GetSemanticModel(tree);
            InsertFileRelations(root, sourceFile);
            InsertMethodRelations(root, sourceFile, model);
        }


        private void AggregateSourceSymbols(InputFile inputFile) {
            var sourceFile = SourceFile.CreateFromInputFile(inputFile);
            var tree = GetSyntaxTree(inputFile);
            var root = (CompilationUnitSyntax) tree.GetRoot();
            var semantic = _compilation.GetSemanticModel(tree);


            var namespaceName = FindNamespace(root);
            if (namespaceName == null) return; //invalid source file! (ie. AssemblyInfo) 

            if (!_namespacesByName.ContainsKey(namespaceName)) {
                _namespacesByName.Add(namespaceName, new SourceNamespace {
                    FullName = namespaceName
                });
            }

            var namespaceObj = _namespacesByName[namespaceName];
            namespaceObj.Files.Add(sourceFile);

            var classes = FindClasses(root).Select(className => new SourceClass {
                Name = className, File = sourceFile
            }).ToList();
            var methods = FindMethods(root).Select(method => {
                var semanticName = GetMethodDeclarationSymbolName(semantic, method);
                var name = $"{method.ReturnType} {method.Identifier}{method.ParameterList}";

                return new SourceMethod {
                    Name = name, ParentFile = sourceFile, SemanticName = semanticName
                };
            }).ToList();

            sourceFile.Namespace = namespaceObj;
            sourceFile.Classes = classes;
            sourceFile.Methods = methods;

            _filesByIdentifier.Add(sourceFile.UniqueIdentifier, sourceFile);
            foreach (var sourceMethod in methods) {
                _methodsBySemanticName.Add(sourceMethod.SemanticName, sourceMethod);
            }

            foreach (var sourceClass in classes) {
                if (_classesByName.ContainsKey(sourceClass.Name)) continue;
                _classesByName.Add(sourceClass.Name, sourceClass);
            }
        }

        private void CompileProject() {
            _compilation = CSharpCompilation.Create("CompileProject")
                .AddReferences(
                    MetadataReference.CreateFromFile(
                        typeof(object).Assembly.Location))
                .AddSyntaxTrees(_syntaxTrees.Values);
        }

        private SyntaxTree GetSyntaxTree(InputFile inputFile) {
            SyntaxTree tree = null;
            if (_syntaxTrees.ContainsKey(inputFile.RelativePath)) {
                tree = _syntaxTrees[inputFile.RelativePath];
            } else {
                tree = CSharpSyntaxTree.ParseText(inputFile.Content);
                _syntaxTrees.Add(inputFile.RelativePath, tree);
            }

            return tree;
        }

        private string FindNamespace(CompilationUnitSyntax root) {
            if (root.Members.Count == 0) return null;
            if (root.Members[0] is NamespaceDeclarationSyntax ns) {
                return ns.Name.ToString();
            }

            return null;
        }

        private IEnumerable<MethodDeclarationSyntax> FindMethods(CSharpSyntaxNode node) {
            return node.DescendantNodes()
                .OfType<MethodDeclarationSyntax>();
        }

        private List<string> FindClasses(CSharpSyntaxNode node) {
            return node.DescendantNodes()
                .OfType<ClassDeclarationSyntax>()
                .Select(classSyntax => $"{classSyntax.Identifier}")
                .ToList();
        }

        private MethodDeclarationSyntax FindParentMethod(CSharpSyntaxNode node) {
            var nodes = node.Ancestors()
                .OfType<MethodDeclarationSyntax>();
            if (nodes.Any()) return nodes.First();
            return null; //could be called from constructor
        }

        private void InsertFileRelations(CSharpSyntaxNode root, SourceFile currentFile) {
            var classIdentifiers = root.DescendantNodes()
                .OfType<IdentifierNameSyntax>()
                .Select(syntax => syntax.Identifier.ToString())
                .Where(name => _classesByName.ContainsKey(name));

            foreach (var identifier in classIdentifiers) {
                var classFile = _classesByName[identifier].File;
                currentFile.AddFileRelation(classFile);
            }
        }

        private string GetMethodDeclarationSymbolName(SemanticModel model, MethodDeclarationSyntax syntax) {
            var methodDeclarationSymbol = model.GetDeclaredSymbol(syntax);
            return methodDeclarationSymbol.ToString();
        }

        private string GetMethodInvocationName(SemanticModel model, InvocationExpressionSyntax syntax) {
            var symbolInfo = model.GetSymbolInfo(syntax);
            return symbolInfo.Symbol?.ToString();
        }

        private void InsertMethodRelations(CSharpSyntaxNode root, SourceFile currentFile, SemanticModel model) {
            var methods = root.DescendantNodes()
                .OfType<InvocationExpressionSyntax>();

            foreach (var invocation in methods) {
                var invokeName = GetMethodInvocationName(model, invocation);
                if (invokeName == null) continue;
                if (_methodsBySemanticName.ContainsKey(invokeName)) {
                    var invokedBy = FindParentMethod(invocation);
                    if (invokedBy == null) continue; // constructor
                    var declarationName = GetMethodDeclarationSymbolName(model, invokedBy);

                    if (_methodsBySemanticName.ContainsKey(declarationName)) {
                        var methodFrom = _methodsBySemanticName[declarationName];
                        var methodTo = _methodsBySemanticName[invokeName];
                        InsertRelationsBetweenMethods(methodFrom, methodTo);
                    }
                }
            }
        }

        private void InsertRelationsBetweenMethods(SourceMethod methodFrom, SourceMethod methodTo) {
            methodFrom.AddMethodRelation(methodTo);
            methodTo.InvokedCount++;
            var nsFrom = methodFrom.ParentFile.Namespace;
            var nsTo = methodTo.ParentFile.Namespace;
            if (nsFrom != nsTo) {
                nsFrom.AddNamespaceRelation(nsTo);
            }
        }
    }
}