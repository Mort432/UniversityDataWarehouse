using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class ComplaintSeed
    {
        public static Complaint Complaint1 { get; } = new Complaint()
        {
            ComplaintText = "The equipment is too dirty.",
            CourseId = CourseSeed.SportsScienceCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id
        };
        
        public static Complaint Complaint2 { get; } = new Complaint()
        {
            ComplaintText = "The computers are too slow.",
            CourseId = CourseSeed.ForensicComputingCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id
        };
        
        public static Complaint Complaint3 { get; } = new Complaint()
        {
            ComplaintText = "The syllabus is out of date.",
            CourseId = CourseSeed.ComputingCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id
        };
        
        public static Complaint Complaint4 { get; } = new Complaint()
        {
            ComplaintText = "I'm bored of reading Shakespeare.",
            CourseId = CourseSeed.EnglishLiteratureCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2016.Id
        };
        
        public static Complaint Complaint5 { get; } = new Complaint()
        {
            ComplaintText = "Why don't we have the latest version of the software?",
            CourseId = CourseSeed.ComputingCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id
        };
        
        public static Complaint Complaint6 { get; } = new Complaint()
        {
            ComplaintText = "The treadmills keep breaking down.",
            CourseId = CourseSeed.SportsScienceCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id
        };
        
        public static Complaint Complaint7 { get; } = new Complaint()
        {
            ComplaintText = "Why haven't we covered Shakespeare?",
            CourseId = CourseSeed.EnglishLiteratureCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2015.Id
        };
        
        public static Complaint Complaint8 { get; } = new Complaint()
        {
            ComplaintText = "We need the latest version of Unity.",
            CourseId = CourseSeed.GameDevelopmentCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2015.Id
        };
        
        public static Complaint Complaint9 { get; } = new Complaint()
        {
            ComplaintText = "We need the latest version of Unity.",
            CourseId = CourseSeed.GameDevelopmentCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2015.Id
        };
        
        public static Complaint Complaint10 { get; } = new Complaint()
        {
            ComplaintText = "The lecturer is late giving feedback.",
            CourseId = CourseSeed.GameDevelopmentCourse.Id,
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id
        };
    }
}