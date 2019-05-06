namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class ClassificationDim
    {
        public int Id { get; set; }
        public string Classification { get; set; }

        public override string ToString()
        {
            return Classification;
        }
    }
}