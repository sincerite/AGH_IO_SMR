using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceMethod : BaseSourceElement {
        public string Name; //should we take into account return and argument types?
        public SourceFile ParentFile;
        public List<SourceRelation<SourceMethod>> MethodRelationsByMethodInvocations; // 2nd story
        public int CyclomaticComplexity;
    }
}