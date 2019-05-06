namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Complaint : EntityBase
    {
        public string ComplaintText { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}