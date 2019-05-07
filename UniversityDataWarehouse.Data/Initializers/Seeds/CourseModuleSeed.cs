using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class CourseModuleSeed
    {
        #region Computing
        public static CourseModule CM1 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.ComputingCourse.Id,
            ModuleId = ModuleSeed.DatabaseSystemsModule.Id
        };
        public static CourseModule CM2 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.ComputingCourse.Id,
            ModuleId = ModuleSeed.AlgorithmsModule.Id
        };
        public static CourseModule CM3 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.ComputingCourse.Id,
            ModuleId = ModuleSeed.EmbeddedSystemsModule.Id
        };
        #endregion
        
        #region Forensic Computing
        public static CourseModule CM4 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.ForensicComputingCourse.Id,
            ModuleId = ModuleSeed.CyberSecurityModule.Id
        };
        public static CourseModule CM5 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.ForensicComputingCourse.Id,
            ModuleId = ModuleSeed.DatabaseSystemsModule.Id
        };
        #endregion
        
        #region Game Dev
        public static CourseModule CM6 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.GameDevelopmentCourse.Id,
            ModuleId = ModuleSeed.AlgorithmsModule.Id
        };
        public static CourseModule CM7 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.GameDevelopmentCourse.Id,
            ModuleId = ModuleSeed.GraphicsEnginesModule.Id
        };
        #endregion
        
        #region Physical Training
        public static CourseModule CM8 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.PhysicalTrainingCourse.Id,
            ModuleId = ModuleSeed.TrainingFormModule.Id
        };
        public static CourseModule CM9 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.PhysicalTrainingCourse.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id
        };
        #endregion
        
        #region Sports Science
        public static CourseModule CM10 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.SportsScienceCourse.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id
        };
        public static CourseModule CM11 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.SportsScienceCourse.Id,
            ModuleId = ModuleSeed.ExerciseAndMentalHealthModule.Id
        };
        public static CourseModule CM12 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.SportsScienceCourse.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id
        };
        #endregion
        
        #region English Lit
        public static CourseModule CM13 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.EnglishLiteratureCourse.Id,
            ModuleId = ModuleSeed.ShakespeareanPlaysModule.Id
        };
        public static CourseModule CM14 { get; } = new CourseModule()
        {
            CourseId = CourseSeed.EnglishLiteratureCourse.Id,
            ModuleId = ModuleSeed.MarloweModule.Id
        };
        #endregion

        public static CourseModule[] ToArray()
        {
            return new[]
            {
                CM1,
                CM2,
                CM3,
                CM4,
                CM5,
                CM6,
                CM7,
                CM8,
                CM9,
                CM10,
                CM11,
                CM12,
                CM13,
                CM14
            };
        }
    }
}