using System;

namespace UniversityDataWarehouse.Data.Entities.Operational
{
    public class AcademicYear : EntityBase
    {
        public int Year { get; set; }
        public DateTime AcademicYearStart { get; set; }
        public DateTime AcademicYearEnd { get; set; }
    }
}