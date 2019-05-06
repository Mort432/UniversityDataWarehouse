namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class ResultFact : FactBase
    {
        public int ModuleDimId { get; set; }
        public virtual ModuleDim ModuleDim { get; set; }

        public int ClassificationDimId { get; set; }
        public virtual ClassificationDim ClassificationDim { get; set; }
    }
}