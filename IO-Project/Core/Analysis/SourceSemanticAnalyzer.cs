using System.Collections.Generic;
using System.Linq;
using IO_Project.Core.Analysis.Models;
using IO_Project.Input;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace IO_Project.Core.Analysis {
    public class SourceSemanticAnalyzer {
        
        public SourceAnalysisModel Analyze(List<InputFile> inputFiles) {

            var namespaces = new Dictionary<string, SourceNamespace>();
            
            foreach (var inputFile in inputFiles) {
                var sourceFile = CreateSourceFileFromInputFile(inputFile);
                var root = ParseSource(inputFile.Content);

                var namespaceName = FindNamespace(root);
                if (!namespaces.ContainsKey(namespaceName)) {
                    namespaces.Add(namespaceName, new SourceNamespace {
                        FullName = namespaceName
                    });
                }
                var namespaceObj = namespaces[namespaceName];
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
            }
            

            return null;
        }

        private CompilationUnitSyntax ParseSource(string source) {
            SyntaxTree tree = CSharpSyntaxTree.ParseText(source);
            return (CompilationUnitSyntax) tree.GetRoot();
        }

        private SourceFile CreateSourceFileFromInputFile(InputFile inputFile) {
            return new SourceFile {
                Filename = inputFile.Filename,
                Path = inputFile.AbsolutePath,
                RelativePath = inputFile.RelativePath,
                Size = inputFile.Size
            };
        }

        private string FindNamespace(CompilationUnitSyntax root) {
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
    }
}