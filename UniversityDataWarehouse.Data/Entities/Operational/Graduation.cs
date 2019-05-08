using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Graduation : EntityBase
    {
        [Key]
        [Column(Order=1)]
        public int YearId { get; set; }
        public AcademicYear Year { get; set; }

        [Key]
        [Column(Order=2)]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Key]
        [Column(Order=3)]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}