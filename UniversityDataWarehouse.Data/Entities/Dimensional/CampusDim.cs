namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class CampusDim
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}