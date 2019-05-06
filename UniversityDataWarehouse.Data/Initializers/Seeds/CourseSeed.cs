using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class CourseSeed
    {
        public static Course ComputingCourse { get; } = new Course()
        {
            Name = "Computing",
            CampusId = CampusSeed.ParkCampus.Id
        };
        
        public static Course ForensicComputingCourse { get; } = new Course()
        {
            Name = "Forensic Computing",
            CampusId = CampusSeed.ParkCampus.Id
        };
        
        public static Course GameDevelopmentCourse { get; } = new Course()
        {
            Name = "Game Development",
            CampusId = CampusSeed.ParkCampus.Id
        };

        public static Course PhysicalTrainingCourse { get; } = new Course()
        {
            Name = "Physical Training",
            CampusId = CampusSeed.OxstallsCampus.Id
        };
        
        public static Course SportsScienceCourse { get; } = new Course()
        {
            Name = "Sports Science",
            CampusId = CampusSeed.OxstallsCampus.Id
        };
        
        public static Course EnglishLiteratureCourse { get; } = new Course()
        {
            Name = "English Literature",
            CampusId = CampusSeed.FCHCampus.Id
        };
        
        public static Course[] ToArray()
        {
            return new[]
            {
                ComputingCourse,
                ForensicComputingCourse,
                GameDevelopmentCourse,
                PhysicalTrainingCourse,
                SportsScienceCourse,
                EnglishLiteratureCourse
            };
        }
    }
}