namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public interface IFact
    {
        int AcademicYearDimId { get; set; }
        AcademicYearDim AcademicYearDim { get; set; }
        
        int Value { get; set; }
    }
}