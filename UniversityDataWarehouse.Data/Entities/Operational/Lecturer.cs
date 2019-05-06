using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Lecturer : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<ModuleRun> ModuleRuns { get; set; }
    }
}