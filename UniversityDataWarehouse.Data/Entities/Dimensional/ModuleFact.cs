namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class ModuleFact : FactBase
    {
        public int CourseDimId { get; set; }
        public virtual CourseDim CourseDim { get; set; }
    }
}