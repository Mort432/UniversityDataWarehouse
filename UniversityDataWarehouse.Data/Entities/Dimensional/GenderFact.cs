using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class GenderFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int GenderDimId { get; set; }
        public virtual GenderDim GenderDim { get; set; }
    }
}