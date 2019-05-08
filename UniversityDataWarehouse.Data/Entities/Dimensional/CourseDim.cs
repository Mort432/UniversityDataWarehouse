using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class CourseDim
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}