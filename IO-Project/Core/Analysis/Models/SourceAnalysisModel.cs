using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceAnalysisModel {
        public List<SourceNamespace> Namespaces;
        public List<SourceFile> Files; //for convenience 
        public string CurrentCommitHash;
    }
}