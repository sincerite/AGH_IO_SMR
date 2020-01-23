using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceFile : BaseSourceElement {
        public string Filename;
        public string Path; //this is our unique identifier
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
    }
}