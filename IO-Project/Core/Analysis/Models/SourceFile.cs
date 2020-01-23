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
        public List<SourceRelation<SourceFile>> FileRelationsByClassReferences =
            new List<SourceRelation<SourceFile>>(); //1st story
        
        public List<SourceMethod> Methods = new List<SourceMethod>(); //6th story

        
        
        public void AddFileRelation(SourceFile file, int referencesCount) {
            FileRelationsByClassReferences.Add(new SourceRelation<SourceFile> {
                Reference = file, ReferencesCount = referencesCount
            });
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