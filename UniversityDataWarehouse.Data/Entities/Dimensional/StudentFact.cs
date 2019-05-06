namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class StudentFact : FactBase
    {
        public int CountryDimId { get; set; }
        public virtual CountryDim CountryDim { get; set; }
    }
}