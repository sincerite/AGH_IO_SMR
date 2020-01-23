using System.Collections.Generic;
using System.Linq;
using IO_Project.Core.Analysis.Models;
using IO_Project.Input;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IO_Project.Core.Analysis {
    public class SourceSemanticAnalyzer {
        private Dictionary<string, SourceNamespace> _namespacesByName;
        private Dictionary<string, SourceFile> _filesByIdentifier;
        private Dictionary<string, SourceMethod> _methodsByIdentifier;
        private Dictionary<string, SourceClass> _classesByName;


        public SourceAnalysisModel Analyze(List<InputFile> inputFiles) {
            ClearState();
            //first iteration
            foreach (var inputFile in inputFiles) {
                AggregateSourceSymbols(inputFile);
            }

            foreach (var inputFile in inputFiles) {
                FindSourceRelations(inputFile);
            }

            return new SourceAnalysisModel {
                CurrentCommitHash = "#hash",
                Files = _filesByIdentifier,
                Namespaces = _namespacesByName
            };
        }

        private void ClearState() {
            _namespacesByName = new Dictionary<string, SourceNamespace>();
            _filesByIdentifier = new Dictionary<string, SourceFile>();
            _methodsByIdentifier = new Dictionary<string, SourceMethod>();
            _classesByName = new Dictionary<string, SourceClass>();
        }

        private void FindSourceRelations(InputFile inputFile) {
            var root = ParseSource(inputFile.Content);

            if(!_filesByIdentifier.ContainsKey(inputFile.RelativePath)) return;
            
            var sourceFile = _filesByIdentifier[inputFile.RelativePath];
            
            InsertFileRelations(root, sourceFile);
            
            
        }

        
        private void AggregateSourceSymbols(InputFile inputFile) {
            var sourceFile = SourceFile.CreateFromInputFile(inputFile);
            var root = ParseSource(inputFile.Content);

            var namespaceName = FindNamespace(root);
            if(namespaceName == null) return; //invalid source file! (ie. AssemblyInfo) 
            
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
            var methods = FindMethods(root).Select(method => new SourceMethod {
                Name = method, ParentFile = sourceFile
            }).ToList();

            sourceFile.Namespace = namespaceObj;
            sourceFile.Classes = classes;
            sourceFile.Methods = methods;

            _filesByIdentifier.Add(sourceFile.UniqueIdentifier, sourceFile);
            foreach (var sourceMethod in methods) {
                _methodsByIdentifier.Add(sourceMethod.UniqueIdentifier, sourceMethod);
            }

            foreach (var sourceClass in classes) {
                if(_classesByName.ContainsKey(sourceClass.Name)) continue;
                _classesByName.Add(sourceClass.Name, sourceClass);
            }
        }

        private CompilationUnitSyntax ParseSource(string source) {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(source);
            return (CompilationUnitSyntax) tree.GetRoot();
        }

        private string FindNamespace(CompilationUnitSyntax root) {
            if (root.Members.Count == 0) return null;
            var nsDeclaration = (NamespaceDeclarationSyntax) root.Members[0];
            return nsDeclaration.Name.ToString();
        }

        private IEnumerable<string> FindMethods(CSharpSyntaxNode node) {
            return node.DescendantNodes()
                .OfType<MethodDeclarationSyntax>()
                .Select(method => $"{method.ReturnType} {method.Identifier}{method.ParameterList}");
        }

        private List<string> FindClasses(CSharpSyntaxNode node) {
            return node.DescendantNodes()
                .OfType<ClassDeclarationSyntax>()
                .Select(classSyntax => $"{classSyntax.Identifier}")
                .ToList();
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
    }
}