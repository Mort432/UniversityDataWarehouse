using System;
using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class AcademicYearSeed
    {
        public static AcademicYear AcademicYear2015 { get; } = new AcademicYear()
        {
            Year = 2015,
            AcademicYearStart = new DateTime(2015, 8, 1),
            AcademicYearEnd = new DateTime(2016, 8, 1)
        };
        
        public static AcademicYear AcademicYear2016 { get; } = new AcademicYear()
        {
            Year = 2016,
            AcademicYearStart = new DateTime(2016, 8, 1),
            AcademicYearEnd = new DateTime(2017, 8, 1)
        };
        
        public static AcademicYear AcademicYear2017 { get; } = new AcademicYear()
        {
            Year = 2017,
            AcademicYearStart = new DateTime(2017, 8, 1),
            AcademicYearEnd = new DateTime(2018, 8, 1)
        };
        
        public static AcademicYear AcademicYear2018 { get; } = new AcademicYear()
        {
            Year = 2018,
            AcademicYearStart = new DateTime(2018, 8, 1),
            AcademicYearEnd = new DateTime(2019, 8, 1)
        };
        public static AcademicYear AcademicYear2019 { get; } = new AcademicYear()
        {
            Year = 2019,
            AcademicYearStart = new DateTime(2019, 8, 1),
            AcademicYearEnd = new DateTime(2020, 8, 1)
        };
        
        public static AcademicYear[] ToArray()
        {
            return new[]
            {
                AcademicYear2015,
                AcademicYear2016,
                AcademicYear2017,
                AcademicYear2018,
                AcademicYear2019
            };
        }
    }
}