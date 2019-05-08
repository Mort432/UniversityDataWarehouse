using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class LecturerFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int LecturerDimId { get; set; }
        public virtual LecturerDim LecturerDim { get; set; }
    }
}