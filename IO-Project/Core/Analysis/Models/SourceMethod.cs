using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceMethod : BaseSourceElement {
        
        public override string UniqueIdentifier => $"{ParentFile.UniqueIdentifier}#{Name}";

        public string Name; //should we take into account return and argument types?
        public SourceFile ParentFile;
        public Dictionary<string, SourceRelation<SourceMethod>> MethodRelationsByMethodInvocations = 
            new Dictionary<string, SourceRelation<SourceMethod>>(); // 2nd story

        public string SemanticName;
        public int InvokedCount;
        public int CyclomaticComplexity;
        
        public void AddMethodRelation(SourceMethod methodTo) {
            var id = methodTo.UniqueIdentifier;
            if (MethodRelationsByMethodInvocations.ContainsKey(id)) {
                MethodRelationsByMethodInvocations[id].ReferencesCount++;
            } else {
                var relation = new SourceRelation<SourceMethod> {
                    Reference = methodTo, ReferencesCount = 1
                };
                MethodRelationsByMethodInvocations.Add(id, relation);
            }
        }
    }
}