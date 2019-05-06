namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class AcademicYearDim
    {
        public int Id { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return Year.ToString();
        }
    }
}