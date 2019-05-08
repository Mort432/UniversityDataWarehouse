using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class ResultFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int ModuleDimId { get; set; }
        public virtual ModuleDim ModuleDim { get; set; }

        [Key]
        [Column(Order=3)]
        public int ClassificationDimId { get; set; }
        public virtual ClassificationDim ClassificationDim { get; set; }
    }
}