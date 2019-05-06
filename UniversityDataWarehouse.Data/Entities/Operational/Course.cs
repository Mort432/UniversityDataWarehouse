using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        
        public int CampusId { get; set; }
        public virtual Campus Campus { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<CourseModule> CourseModules { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
    }
}