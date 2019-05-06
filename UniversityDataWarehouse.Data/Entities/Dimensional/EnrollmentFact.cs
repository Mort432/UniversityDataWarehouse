namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class EnrollmentFact : FactBase
    {
        public int ModuleDimId { get; set; }
        public virtual ModuleDim ModuleDim { get; set; }
    }
}