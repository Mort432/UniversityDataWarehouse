using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class CourseModule
    {
        [Key]
        [Column(Order = 1)]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        
        [Key]
        [Column(Order = 2)]
        public int ModuleId { get; set; }
        public virtual Module Module { get; set; }
    }
}