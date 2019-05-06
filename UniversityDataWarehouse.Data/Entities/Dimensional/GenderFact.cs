namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class GenderFact : FactBase
    {
        public int GenderDimId { get; set; }
        public virtual GenderDim GenderDim { get; set; }
    }
}