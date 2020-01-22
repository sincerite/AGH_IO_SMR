namespace IO_Project.Core.Analysis.Models {
    public class SourceRelation <T> where T : BaseSourceElement {
        public T Reference;
        public int ReferencesCount;
    }
}