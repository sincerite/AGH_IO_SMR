using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceFile : BaseSourceElement {
        public string Filename;
        public string Path; //this is our unique identifier
        public string RelativePath;
        public long Size;

        //analysis based:
        public SourceNamespace Namespace;
        public List<SourceRelation<SourceFile>> FileRelationsByClassReferences; //1st story
        public List<SourceMethod> Methods; //6th story
    }
}