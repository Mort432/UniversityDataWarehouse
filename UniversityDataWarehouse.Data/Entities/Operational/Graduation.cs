using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Graduation : EntityBase
    {
        public int YearId { get; set; }
        public AcademicYear Year { get; set; }

        public int StudentId { get; set; }
        public virtual Student User { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}