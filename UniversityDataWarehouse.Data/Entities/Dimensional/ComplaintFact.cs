using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class ComplaintFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int CourseDimId { get; set; }
        public virtual CourseDim CourseDim { get; set; }
    }
}