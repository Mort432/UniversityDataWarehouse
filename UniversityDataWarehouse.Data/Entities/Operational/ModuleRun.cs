using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class ModuleRun : EntityBase
    {
        [Key]
        [Column(Order=1)]
        public int AcademicYearId { get; set; }
        public virtual AcademicYear Year { get; set; }
        
        [Key]
        [Column(Order=2)]
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }

        [Key]
        [Column(Order=3)]
        public int LecturerId { get; set; }
        public virtual Lecturer Lecturer { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}