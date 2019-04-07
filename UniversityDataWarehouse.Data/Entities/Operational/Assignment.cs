using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Assignment : EntityBase
    {
        public string Title { get; set; }

        public int ModuleRunId { get; set; }
        public virtual ModuleRun ModuleRun { get; set; }
        
        public virtual ICollection<Result> Results { get; set; }
    }
}