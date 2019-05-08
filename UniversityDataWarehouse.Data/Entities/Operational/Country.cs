using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Country : EntityBase
    {
        public string Name { get; set; }
        
        public virtual ICollection<Student> Students { get; set; }
    }
}