using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class EnrollmentFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int ModuleDimId { get; set; }
        public virtual ModuleDim ModuleDim { get; set; }
    }
}