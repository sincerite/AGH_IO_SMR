using System.Collections.Generic;

namespace IO_Project.Core.Analysis.Models {
    public class SourceAnalysisModel {
        public Dictionary<string, SourceNamespace> Namespaces;
        public Dictionary<string, SourceFile> Files; //for convenience 
        public string CurrentCommitHash;
    }
}