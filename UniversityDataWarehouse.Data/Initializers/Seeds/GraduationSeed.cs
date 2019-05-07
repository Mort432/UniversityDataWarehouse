using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class GraduationSeed
    {
        public static Graduation Grad1 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2018.Id,
            UserId = StudentSeed.EveKennedy.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Graduation Grad2 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2019.Id,
            UserId = StudentSeed.MaxMoisio.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Graduation Grad3 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2018.Id,
            UserId = StudentSeed.DianaRodriguez.Id,
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Graduation Grad4 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2018.Id,
            UserId = StudentSeed.JacobSmith.Id,
            CourseId = CourseSeed.GameDevelopmentCourse.Id
        };
        
        public static Graduation Grad5 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2015.Id,
            UserId = StudentSeed.LandenPate.Id,
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };

        public static Graduation[] ToArray()
        {
            return new[]
            {
                Grad1,
                Grad2,
                Grad3,
                Grad4,
                Grad5
            };
        }
    }
}