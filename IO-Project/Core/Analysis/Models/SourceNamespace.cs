using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceNamespace : BaseSourceElement {

        public override string UniqueIdentifier => FullName;

        public string FullName;
        public List<SourceFile> Files = new List<SourceFile>();
        public int ReferencedCount => Files.Count;

        public Dictionary<string, SourceRelation<SourceNamespace>> NamespacesRelationsByMethodReferences =
            new Dictionary<string, SourceRelation<SourceNamespace>>(); //3rd story

        
        
        public void AddNamespaceRelation(SourceNamespace namespaceTo) {
            var id = namespaceTo.UniqueIdentifier;
            if (NamespacesRelationsByMethodReferences.ContainsKey(id)) {
                NamespacesRelationsByMethodReferences[id].ReferencesCount++;
            } else {
                var relation = new SourceRelation<SourceNamespace> {
                    Reference = namespaceTo, ReferencesCount = 1
                };
                NamespacesRelationsByMethodReferences.Add(id, relation);
            }
        }
    }
}