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
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.ComputingCourse.Id
        };
        
        public static Student ThomasClark { get; } = new Student()
        {
            FirstName = "Thomas",
            LastName = "Clark",
            Gender = "Male",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.ComputingCourse.Id
        };
        
        public static Student LaibaKhawar { get; } = new Student()
        {
            FirstName = "Laiba",
            LastName = "Khawar",
            Gender = "Female",
            CountryId = CountrySeed.Pakistan.Id,
            CourseId = CourseSeed.ComputingCourse.Id
        };
        
        public static Student GuyMorley { get; } = new Student()
        {
            FirstName = "Guy",
            LastName = "Morley",
            Gender = "Male",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.ForensicComputingCourse.Id
        };
        
        public static Student EmiliaChapman { get; } = new Student()
        {
            FirstName = "Emilia",
            LastName = "Chapman",
            Gender = "Female",
            CountryId = CountrySeed.France.Id,
            CourseId = CourseSeed.ForensicComputingCourse.Id
        };
        
        public static Student JacobSmith { get; } = new Student()
        {
            FirstName = "Jacob",
            LastName = "Smith",
            Gender = "Male",
            CountryId = CountrySeed.France.Id,
            CourseId = CourseSeed.GameDevelopmentCourse.Id
        };
        
        public static Student YousefGood { get; } = new Student()
        {
            FirstName = "Yousef",
            LastName = "Good",
            Gender = "Male",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.GameDevelopmentCourse.Id
        };
        
        public static Student LandenPate { get; } = new Student()
        {
            FirstName = "Landen",
            LastName = "Pate",
            Gender = "Male",
            CountryId = CountrySeed.UnitedStates.Id,
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Student NicoleRichards { get; } = new Student()
        {
            FirstName = "Nicole",
            LastName = "Richards",
            Gender = "Female",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Student DianaRodriguez { get; } = new Student()
        {
            FirstName = "Diana",
            LastName = "Rodriguez",
            Gender = "Female",
            CountryId = CountrySeed.Pakistan.Id,
            CourseId = CourseSeed.PhysicalTrainingCourse.Id
        };
        
        public static Student HalleHoffman { get; } = new Student()
        {
            FirstName = "Halle",
            LastName = "Hoffman",
            Gender = "Female",
            CountryId = CountrySeed.France.Id,
            CourseId = CourseSeed.SportsScienceCourse.Id
        };
        
        public static Student TylerBrooks { get; } = new Student()
        {
            FirstName = "Tyler",
            LastName = "Brooks",
            Gender = "Male",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.SportsScienceCourse.Id
        };
        
        public static Student MaxMoisio { get; } = new Student()
        {
            FirstName = "Max",
            LastName = "Moisio",
            Gender = "Male",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Student JoeKaufman { get; } = new Student()
        {
            FirstName = "Joe",
            LastName = "Kaufman",
            Gender = "Male",
            CountryId = CountrySeed.UnitedStates.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };
        
        public static Student EveKennedy { get; } = new Student()
        {
            FirstName = "Eve",
            LastName = "Kennedy",
            Gender = "Female",
            CountryId = CountrySeed.UnitedKingdom.Id,
            CourseId = CourseSeed.EnglishLiteratureCourse.Id
        };

        public static Student[] ToArray()
        {
            return new[]
            {
                ConnaghMuldoon,
                ThomasClark,
                LaibaKhawar,
                GuyMorley,
                EmiliaChapman,
                JacobSmith,
                YousefGood,
                LandenPate,
                NicoleRichards,
                DianaRodriguez,
                HalleHoffman,
                TylerBrooks,
                MaxMoisio,
                JoeKaufman,
                EveKennedy
            };
        }
    }
}