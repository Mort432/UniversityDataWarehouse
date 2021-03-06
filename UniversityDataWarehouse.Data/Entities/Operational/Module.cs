using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Module : EntityBase
    {
        public string Name { get; set; }
        
        public virtual ICollection<CourseModule> CourseModules { get; set; }
        public virtual ICollection<ModuleRun> ModuleRuns { get; set; }
    }
}