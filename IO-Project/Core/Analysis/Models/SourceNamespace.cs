using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceNamespace : BaseSourceElement {
        public string FullName;
        public List<SourceFile> Files;
        public List<SourceRelation<SourceNamespace>> NamespacesRelationsByMethodReferences; //3rd story
    }
}