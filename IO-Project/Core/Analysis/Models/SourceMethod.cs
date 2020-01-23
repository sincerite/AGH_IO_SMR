using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceMethod : BaseSourceElement {
        
        public override string UniqueIdentifier => $"{ParentFile.UniqueIdentifier}#{Name}";

        public string Name; //should we take into account return and argument types?
        public SourceFile ParentFile;
        public List<SourceRelation<SourceMethod>> MethodRelationsByMethodInvocations = 
            new List<SourceRelation<SourceMethod>>(); // 2nd story
        
        public int InvokedCount;
        public int CyclomaticComplexity;
        
        public void AddMethodRelation(SourceMethod method, int referencesCount) {
            MethodRelationsByMethodInvocations.Add(new SourceRelation<SourceMethod> {
                Reference = method, ReferencesCount = referencesCount
            });
        }
    }
}