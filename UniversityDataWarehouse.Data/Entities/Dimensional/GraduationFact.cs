namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class GraduationFact : FactBase
    {
        public int CourseDimId { get; set; }
        public virtual CourseDim CourseDim { get; set; }
    }
}