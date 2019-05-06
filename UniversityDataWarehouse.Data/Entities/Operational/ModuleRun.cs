using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class ModuleRun : EntityBase
    {
        public int AcademicYearId { get; set; }
        public virtual AcademicYear Year { get; set; }
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}