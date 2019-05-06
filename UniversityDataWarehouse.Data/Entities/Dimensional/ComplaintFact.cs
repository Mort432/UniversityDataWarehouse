namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class ComplaintFact : FactBase
    {
        public int CourseDimId { get; set; }
        public virtual CourseDim CourseDim { get; set; }
    }
}