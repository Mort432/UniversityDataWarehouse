namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Graduation : EntityBase
    {
        public int YearId { get; set; }
        public AcademicYear Year { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}