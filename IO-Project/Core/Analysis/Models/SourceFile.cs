using System.Collections.Generic;
using IO_Project.Input;

namespace IO_Project.Core.Analysis.Models {
    public class SourceFile : BaseSourceElement {
        
        public override string UniqueIdentifier => RelativePath;

        public string Filename;
        public string Path;
        public string RelativePath;
        public long Size;

        //analysis based:
        public SourceNamespace Namespace;
        public List<SourceClass> Classes = new List<SourceClass>();
        public Dictionary<string, SourceRelation<SourceFile>> FileRelationsByClassReferences =
            new Dictionary<string, SourceRelation<SourceFile>>(); //1st story
        
        public List<SourceMethod> Methods = new List<SourceMethod>(); //6th story

        
        
        public void AddFileRelation(SourceFile file) {
            var id = file.UniqueIdentifier;
            if (FileRelationsByClassReferences.ContainsKey(id)) {
                FileRelationsByClassReferences[id].ReferencesCount++;
            } else {
                var relation = new SourceRelation<SourceFile> {
                    Reference = file, ReferencesCount = 1
                };
                FileRelationsByClassReferences.Add(id, relation);
            }
        }
        
        public static SourceFile CreateFromInputFile(InputFile inputFile) {
            return new SourceFile {
                Filename = inputFile.Filename,
                Path = inputFile.AbsolutePath,
                RelativePath = inputFile.RelativePath,
                Size = inputFile.Size
            };
        }
    }
}