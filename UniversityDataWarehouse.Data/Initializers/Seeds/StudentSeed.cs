using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class StudentSeed
    {
        public static Student ConnaghMuldoon { get; } = new Student()
        {
            FirstName = "Connagh",
            LastName = "Muldoon",
            Gender = "Male",
            CourseId = CourseSeed.ComputingCourse.Id
        };
        
        public static Student ThomasClark { get; } = new Student()
        {
            FirstName = "Thomas",
            LastName = "Clark",
            Gender = "Male",
            CourseId = CourseSeed.ComputingCourse.Id
        };
        
        public static Student LaibaKhawar { get; } = new Student()
        {
            FirstName = "Laiba",
            LastName = "Khawar",
            Gender = "Female",
            CourseId = CourseSeed.ComputingCourse.Id
        };
        
        public static Student GuyMorley { get; } = new Student()
        {
            FirstName = "Guy",
            LastName = "Morley",
            Gender = "Male",
            CourseId = CourseSeed.ForensicComputingCourse.Id
        };
        
        public static Student EmiliaChapman { get; } = new Student()
        {
            FirstName = "Emilia",
            LastName = "Chapman",
            Gender = "Female",
            CourseId = CourseSeed.ForensicComputingCourse.Id
        };
        
        public static Student JacobSmith { get; } = new Student()
        {
            FirstName = "Jacob",
            LastName = "Smith",
            Gender = "Male",
            CourseId = CourseSeed.GameDevelopmentCourse.Id
        };
        
        public static Student YousefGood { get; } = new Student()
        {
            FirstName = "Yousef",
            LastName = "Good",
            Gender = "Male",
            CourseId = CourseSeed.GameDevelopmentCourse.Id
        };
        
        public static Student LandenPate { get; } = new Student()
        {
            FirstName = "Landen",
            LastName = "Pate",
            Gender = "Male",
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Student NicoleRichards { get; } = new Student()
        {
            FirstName = "Nicole",
            LastName = "Richards",
            Gender = "Female",
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Student DianaRodriguez { get; } = new Student()
        {
            FirstName = "Diana",
            LastName = "Rodriguez",
            Gender = "Female",
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Student HalleHoffman { get; } = new Student()
        {
            FirstName = "Halle",
            LastName = "Hoffman",
            Gender = "Female",
            CourseId = CourseSeed.SportsScienceCourse.Id
        };
        
        public static Student TylerBrooks { get; } = new Student()
        {
            FirstName = "Tyler",
            LastName = "Brooks",
            Gender = "Male",
            CourseId = CourseSeed.SportsScienceCourse.Id
        };
        
        public static Student MaxMoisio { get; } = new Student()
        {
            FirstName = "Max",
            LastName = "Moisio",
            Gender = "Male",
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Student JoeKaufman { get; } = new Student()
        {
            FirstName = "Joe",
            LastName = "Kaufman",
            Gender = "Male",
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Student EveKennedy { get; } = new Student()
        {
            FirstName = "Eve",
            LastName = "Kennedy",
            Gender = "Female",
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
    }
}