using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class ModuleRun : EntityBase
    {
        public int Year { get; set; }
        public int Semester { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}