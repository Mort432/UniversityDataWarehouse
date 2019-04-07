namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Result : EntityBase
    {
        public int Grade { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}