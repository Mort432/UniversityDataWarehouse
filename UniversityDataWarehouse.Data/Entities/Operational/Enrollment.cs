using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Enrollment
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ModuleRunId { get; set; }
        public virtual ModuleRun ModuleRun { get; set; }
    }
}