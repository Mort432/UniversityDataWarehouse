namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class CourseFact : FactBase
    {
        public int CampusDimId { get; set; }
        public virtual CampusDim CampusDim { get; set; }
    }
}