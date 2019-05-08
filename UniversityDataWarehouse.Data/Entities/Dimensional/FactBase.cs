using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class FactBase : IFact
    {
        [Key]
        [Column(Order=1)]
        public int AcademicYearDimId { get; set; }
        public virtual AcademicYearDim AcademicYearDim { get; set; }

        public int Value { get; set; }
    }
}