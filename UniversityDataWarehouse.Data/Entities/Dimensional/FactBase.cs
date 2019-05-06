namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class FactBase : IFact
    {
        public int AcademicYearDimId { get; set; }
        public virtual AcademicYearDim AcademicYearDim { get; set; }

        public int Value { get; set; }
    }
}