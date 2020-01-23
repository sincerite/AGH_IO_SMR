namespace IO_Project.Core.Analysis.Models {
    public class SourceClass : BaseSourceElement {
        
        public override string UniqueIdentifier => $"{File?.RelativePath}/{Name}";
        
        public string Name;
        public SourceFile File;
    }
}