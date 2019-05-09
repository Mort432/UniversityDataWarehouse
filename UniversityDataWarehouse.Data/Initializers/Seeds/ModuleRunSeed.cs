using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class ModuleRunSeed
    {
        #region Databases Runs
        public static ModuleRun DBSMRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.DatabaseSystemsModule.Id,
            LecturerId = LecturerSeed.AbuAlam.Id
        };
        public static ModuleRun DBSMRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.DatabaseSystemsModule.Id,
            LecturerId = LecturerSeed.AbuAlam.Id
        };
        #endregion
        
        #region Cyber Runs
        public static ModuleRun CyberRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.CyberSecurityModule.Id,
            LecturerId = LecturerSeed.JuliePaterson.Id
        };
        public static ModuleRun CyberRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.CyberSecurityModule.Id,
            LecturerId = LecturerSeed.JuliePaterson.Id
        };
        public static ModuleRun CyberRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.CyberSecurityModule.Id,
            LecturerId = LecturerSeed.JuliePaterson.Id
        };
        #endregion
        
        #region Embedded Runs
        public static ModuleRun EmbedRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.EmbeddedSystemsModule.Id,
            LecturerId = LecturerSeed.AhsanIkram.Id
        };
        public static ModuleRun EmbedRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.EmbeddedSystemsModule.Id,
            LecturerId = LecturerSeed.AhsanIkram.Id
        };
        public static ModuleRun EmbedRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.EmbeddedSystemsModule.Id,
            LecturerId = LecturerSeed.AhsanIkram.Id
        };
        #endregion
        
        #region Shakespeare Runs
        public static ModuleRun ShakespeareRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.ShakespeareanPlaysModule.Id,
            LecturerId = LecturerSeed.TomWillis.Id
        };
        public static ModuleRun ShakespeareRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.ShakespeareanPlaysModule.Id,
            LecturerId = LecturerSeed.TomWillis.Id
        };
        public static ModuleRun ShakespeareRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.ShakespeareanPlaysModule.Id,
            LecturerId = LecturerSeed.TomWillis.Id
        };
        #endregion
        
        #region Marlowe Runs
        public static ModuleRun MarloweRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2015.Id,
            ModuleId = ModuleSeed.MarloweModule.Id,
            LecturerId = LecturerSeed.TomWillis.Id
        };
        public static ModuleRun MarloweRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2016.Id,
            ModuleId = ModuleSeed.MarloweModule.Id,
            LecturerId = LecturerSeed.TomWillis.Id
        };
        public static ModuleRun MarloweRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.MarloweModule.Id,
            LecturerId = LecturerSeed.JudyHarper.Id
        };
        #endregion
        
        #region First Aid Runs
        public static ModuleRun FirstAidRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2015.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id,
            LecturerId = LecturerSeed.DominicForbes.Id
        };
        public static ModuleRun FirstAidRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2016.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id,
            LecturerId = LecturerSeed.DominicForbes.Id
        };
        public static ModuleRun FirstAidRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id,
            LecturerId = LecturerSeed.DominicForbes.Id
        };
        public static ModuleRun FirstAidRun4 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id,
            LecturerId = LecturerSeed.DominicForbes.Id
        };
        public static ModuleRun FirstAidRun5 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.FirstAidModule.Id,
            LecturerId = LecturerSeed.DominicForbes.Id
        };
        #endregion
        
        #region Respiratory Health Runs
        public static ModuleRun RespHealthRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id,
            LecturerId = LecturerSeed.LydiaGrant.Id
        };
        public static ModuleRun RespHealthRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id,
            LecturerId = LecturerSeed.LydiaGrant.Id
        };
        public static ModuleRun RespHealthRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id,
            LecturerId = LecturerSeed.CallieMcClure.Id
        };
        #endregion
        
        #region Exercise and Mental Health Runs
        public static ModuleRun EMHRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id,
            LecturerId = LecturerSeed.CallieMcClure.Id
        };
        public static ModuleRun EMHRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id,
            LecturerId = LecturerSeed.CallieMcClure.Id
        };
        public static ModuleRun EMHRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.RespiratoryHealthModule.Id,
            LecturerId = LecturerSeed.NoahDoyle.Id
        };
        #endregion
        
        #region Training Form Runs
        public static ModuleRun TrainingFormRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2015.Id,
            ModuleId = ModuleSeed.TrainingFormModule.Id,
            LecturerId = LecturerSeed.SeanFoley.Id
        };
        public static ModuleRun TrainingFormRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.TrainingFormModule.Id,
            LecturerId = LecturerSeed.SeanFoley.Id
        };
        public static ModuleRun TrainingFormRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.TrainingFormModule.Id,
            LecturerId = LecturerSeed.SeanFoley.Id
        };
        #endregion
        
        #region Graphics Engines Runs
        public static ModuleRun GraphicsRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2016.Id,
            ModuleId = ModuleSeed.GraphicsEnginesModule.Id,
            LecturerId = LecturerSeed.CarmenRichards.Id
        };
        public static ModuleRun GraphicsRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2017.Id,
            ModuleId = ModuleSeed.GraphicsEnginesModule.Id,
            LecturerId = LecturerSeed.CarmenRichards.Id
        };
        public static ModuleRun GraphicsRun3 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.GraphicsEnginesModule.Id,
            LecturerId = LecturerSeed.CarmenRichards.Id
        };
        public static ModuleRun GraphicsRun4 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.GraphicsEnginesModule.Id,
            LecturerId = LecturerSeed.CarmenRichards.Id
        };
        #endregion
        
        #region Algorithms Modules
        public static ModuleRun AlgoRun1 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2018.Id,
            ModuleId = ModuleSeed.AlgorithmsModule.Id,
            LecturerId = LecturerSeed.KiranJoyner.Id
        };
        public static ModuleRun AlgoRun2 { get; } = new ModuleRun()
        {
            AcademicYearId = AcademicYearSeed.AcademicYear2019.Id,
            ModuleId = ModuleSeed.AlgorithmsModule.Id,
            LecturerId = LecturerSeed.KiranJoyner.Id
        };
        #endregion

        public static ModuleRun[] ToArray()
        {
            return new[]
            {
                DBSMRun1,
                DBSMRun2,
                CyberRun1,
                CyberRun2,
                CyberRun3,
                EmbedRun1,
                EmbedRun2,
                EmbedRun3,
                ShakespeareRun1,
                ShakespeareRun2,
                ShakespeareRun3,
                MarloweRun1,
                MarloweRun2,
                MarloweRun3,
                FirstAidRun1,
                FirstAidRun2,
                FirstAidRun3,
                FirstAidRun4,
                FirstAidRun5,
                RespHealthRun1,
                RespHealthRun2,
                RespHealthRun3,
                EMHRun1,
                EMHRun2,
                EMHRun3,
                TrainingFormRun1,
                TrainingFormRun2,
                TrainingFormRun3,
                GraphicsRun1,
                GraphicsRun2,
                GraphicsRun3,
                GraphicsRun4,
                AlgoRun1,
                AlgoRun2
            };
        }
    }
}