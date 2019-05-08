using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class Result : EntityBase
    {
        public int Grade { get; set; }

        [Key]
        [Column(Order=1)]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [Key]
        [Column(Order=2)]
        public int AssignmentId { get; set; }
        public virtual Assignment Assignment { get; set; }
    }
}