using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class StudentFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int CountryDimId { get; set; }
        public virtual CountryDim CountryDim { get; set; }
    }
}