using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class FactBase : IFact
    {
        //We know that every Fact is modelled against the Year dimension and will have a value of some kind, so
        //we can use this base class to enforce that (and do fun things with generics).
        [Key]
        [Column(Order=1)]
        public int AcademicYearDimId { get; set; }
        public virtual AcademicYearDim AcademicYearDim { get; set; }

        public int Value { get; set; }
    }
}