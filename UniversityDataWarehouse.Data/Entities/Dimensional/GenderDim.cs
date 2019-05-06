namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class GenderDim
    {
        public int Id { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return Gender;
        }
    }
}