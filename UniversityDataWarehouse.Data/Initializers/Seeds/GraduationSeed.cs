using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class GraduationSeed
    {
        public static Graduation Grad1 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2018.Id,
            StudentId = StudentSeed.EveKennedy.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Graduation Grad2 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2019.Id,
            StudentId = StudentSeed.MaxMoisio.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Graduation Grad3 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2018.Id,
            StudentId = StudentSeed.DianaRodriguez.Id,
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Graduation Grad4 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2018.Id,
            StudentId = StudentSeed.JacobSmith.Id,
            CourseId = CourseSeed.GameDevelopmentCourse.Id
        };
        
        public static Graduation Grad5 { get; } = new Graduation()
        {
            YearId = AcademicYearSeed.AcademicYear2015.Id,
            StudentId = StudentSeed.LandenPate.Id,
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