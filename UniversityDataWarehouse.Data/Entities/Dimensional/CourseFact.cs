using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class CourseFact : FactBase
    {
        [Key]
        [Column(Order=2)]
        public int CampusDimId { get; set; }
        public virtual CampusDim CampusDim { get; set; }
    }
}