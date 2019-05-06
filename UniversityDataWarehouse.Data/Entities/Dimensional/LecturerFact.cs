namespace UniversityDataWarehouse.Data.Entities.Dimensional
{
    public class LecturerFact : FactBase
    {
        public int LecturerDimId { get; set; }
        public virtual LecturerDim LecturerDim { get; set; }
    }
}