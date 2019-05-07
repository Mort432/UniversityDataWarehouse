using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class EnrollmentSeed
    {
        #region Connagh Muldoon
        public static Enrollment E1 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.ConnaghMuldoon.Id,
            ModuleRunId = ModuleRunSeed.DBSMRun1.Id
        };
        public static Enrollment E2 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.ConnaghMuldoon.Id,
            ModuleRunId = ModuleRunSeed.EmbedRun1.Id
        };
        public static Enrollment E3 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.ConnaghMuldoon.Id,
            ModuleRunId = ModuleRunSeed.AlgoRun1.Id
        };
        #endregion
        
        #region Thomas Clark
        public static Enrollment E4 { get; } = new Enrollment()
        {
          StudentId = StudentSeed.ThomasClark.Id,
          ModuleRunId = ModuleRunSeed.EmbedRun1.Id
        };
        public static Enrollment E5 { get; } = new Enrollment()
        {
          StudentId = StudentSeed.ThomasClark.Id,
          ModuleRunId = ModuleRunSeed.DBSMRun1.Id
        };
        public static Enrollment E6 { get; } = new Enrollment()
        {
          StudentId = StudentSeed.ThomasClark.Id,
          ModuleRunId = ModuleRunSeed.AlgoRun1.Id
        };
        #endregion
                          
        #region Laiba Khawar
        public static Enrollment E7 { get; } = new Enrollment()
        {
          StudentId = StudentSeed.LaibaKhawar.Id,
          ModuleRunId = ModuleRunSeed.EmbedRun1.Id
        };
        public static Enrollment E8 { get; } = new Enrollment()
        {
          StudentId = StudentSeed.LaibaKhawar.Id,
          ModuleRunId = ModuleRunSeed.DBSMRun1.Id
        };
        public static Enrollment E9 { get; } = new Enrollment()
        {
          StudentId = StudentSeed.LaibaKhawar.Id,
          ModuleRunId = ModuleRunSeed.AlgoRun1.Id
        };
        #endregion
        
        #region Guy Morley
        public static Enrollment E10 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.GuyMorley.Id,
            ModuleRunId = ModuleRunSeed.DBSMRun2.Id
        };
        public static Enrollment E11 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.GuyMorley.Id,
            ModuleRunId = ModuleRunSeed.CyberRun2.Id
        };
        #endregion
        
        #region Emilia Chapman
        public static Enrollment E12 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.EmiliaChapman.Id,
            ModuleRunId = ModuleRunSeed.CyberRun2.Id
        };
        public static Enrollment E13 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.EmiliaChapman.Id,
            ModuleRunId = ModuleRunSeed.DBSMRun2.Id
        };
        #endregion
        
        #region Jacob Smith
        public static Enrollment E14 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.JacobSmith.Id,
            ModuleRunId = ModuleRunSeed.AlgoRun1.Id
        };
        public static Enrollment E15 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.JacobSmith.Id,
            ModuleRunId = ModuleRunSeed.GraphicsRun3.Id
        };
        #endregion
        
        #region Yousef Good
        public static Enrollment E16 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.YousefGood.Id,
            ModuleRunId = ModuleRunSeed.AlgoRun2.Id
        };
        public static Enrollment E17 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.YousefGood.Id,
            ModuleRunId = ModuleRunSeed.GraphicsRun4.Id
        };
        #endregion
        
        #region Landen Pate
        public static Enrollment E18 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.LandenPate.Id,
            ModuleRunId = ModuleRunSeed.TrainingFormRun1.Id
        };
        public static Enrollment E19 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.LandenPate.Id,
            ModuleRunId = ModuleRunSeed.FirstAidRun1.Id
        };
        #endregion
        
        #region Nicole Richards
        public static Enrollment E20 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.NicoleRichards.Id,
            ModuleRunId = ModuleRunSeed.TrainingFormRun2.Id
        };
        public static Enrollment E21 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.NicoleRichards.Id,
            ModuleRunId = ModuleRunSeed.FirstAidRun2.Id
        };
        #endregion
        
        #region Diana Rodriguez
        public static Enrollment E22 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.DianaRodriguez.Id,
            ModuleRunId = ModuleRunSeed.TrainingFormRun2.Id
        };
        public static Enrollment E23 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.DianaRodriguez.Id,
            ModuleRunId = ModuleRunSeed.FirstAidRun2.Id
        };
        #endregion
        
        #region Halle Hoffman
        public static Enrollment E24 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.HalleHoffman.Id,
            ModuleRunId = ModuleRunSeed.FirstAidRun1.Id
        };
        public static Enrollment E25 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.HalleHoffman.Id,
            ModuleRunId = ModuleRunSeed.EMHRun1.Id
        };
        public static Enrollment E26 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.HalleHoffman.Id,
            ModuleRunId = ModuleRunSeed.RespHealthRun1.Id
        };
        #endregion
        
        #region Tyler Brooks
        public static Enrollment E27 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.TylerBrooks.Id,
            ModuleRunId = ModuleRunSeed.FirstAidRun1.Id
        };
        public static Enrollment E28 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.TylerBrooks.Id,
            ModuleRunId = ModuleRunSeed.EMHRun1.Id
        };
        public static Enrollment E29 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.TylerBrooks.Id,
            ModuleRunId = ModuleRunSeed.RespHealthRun1.Id
        };
        #endregion
        
        #region Max Moisio
        public static Enrollment E30 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.MaxMoisio.Id,
            ModuleRunId = ModuleRunSeed.ShakespeareRun3.Id
        };
        public static Enrollment E31 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.MaxMoisio.Id,
            ModuleRunId = ModuleRunSeed.MarloweRun3.Id
        };
        #endregion
        
        #region Joe Kaufman
        public static Enrollment E32 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.JoeKaufman.Id,
            ModuleRunId = ModuleRunSeed.ShakespeareRun3.Id
        };
        public static Enrollment E33 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.JoeKaufman.Id,
            ModuleRunId = ModuleRunSeed.MarloweRun3.Id
        };
        #endregion
        
        #region Eve Kennedy
        public static Enrollment E34 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.EveKennedy.Id,
            ModuleRunId = ModuleRunSeed.ShakespeareRun2.Id
        };
        public static Enrollment E35 { get; } = new Enrollment()
        {
            StudentId = StudentSeed.EveKennedy.Id,
            ModuleRunId = ModuleRunSeed.MarloweRun2.Id
        };
        #endregion

        public static Enrollment[] ToArray()
        {
            return new[]
            {
                E1,
                E2,
                E3,
                E4,
                E5,
                E6,
                E7,
                E8,
                E9,
                E10,
                E11,
                E12,
                E13,
                E14,
                E15,
                E16,
                E17,
                E18,
                E19,
                E20,
                E21,
                E22,
                E23,
                E24,
                E25,
                E26,
                E27,
                E28,
                E29,
                E30,
                E31,
                E32,
                E33,
                E34,
                E35
            };
        }
    }
}