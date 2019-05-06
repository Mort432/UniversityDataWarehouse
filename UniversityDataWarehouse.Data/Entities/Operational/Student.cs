using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Student : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Gender { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}