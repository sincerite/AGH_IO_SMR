using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceNamespace : BaseSourceElement {
        public string FullName;
        public List<SourceFile> Files = new List<SourceFile>();
        public List<SourceRelation<SourceNamespace>> NamespacesRelationsByMethodReferences =
            new List<SourceRelation<SourceNamespace>>(); //3rd story

        public void AddNamespaceRelation(SourceNamespace sourceNamespace, int referencesCount) {
            NamespacesRelationsByMethodReferences.Add(new SourceRelation<SourceNamespace> {
                Reference = sourceNamespace, ReferencesCount = referencesCount
            });
        }
    }
}