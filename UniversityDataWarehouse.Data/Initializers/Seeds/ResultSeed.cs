using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class ResultSeed
    {
        #region Connagh Muldoon
        public static Result R1 { get; } = new Result()
        {
            //Hint hint ;D
            Grade = 100,
            StudentId = StudentSeed.ConnaghMuldoon.Id,
            AssignmentId = AssignmentSeed.DBSMA1.Id
        };
        public static Result R2 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.ConnaghMuldoon.Id,
            AssignmentId = AssignmentSeed.EmbedA1.Id
        };
        public static Result R3 { get; } = new Result()
        {
            Grade = 60,
            StudentId = StudentSeed.ConnaghMuldoon.Id,
            AssignmentId = AssignmentSeed.AlgoA1.Id
        };
        #endregion
        
        #region Thomas Clark
        public static Result R4 { get; } = new Result()
        {
            Grade = 70,
            StudentId = StudentSeed.ThomasClark.Id,
            AssignmentId = AssignmentSeed.EmbedA1.Id
        };
        public static Result R5 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.ThomasClark.Id,
            AssignmentId = AssignmentSeed.DBSMA1.Id
        };
        public static Result R6 { get; } = new Result()
        {
            Grade = 90,
            StudentId = StudentSeed.ThomasClark.Id,
            AssignmentId = AssignmentSeed.AlgoA1.Id
        };
        #endregion
        
        #region Laiba Khawar
        public static Result R7 { get; } = new Result()
        {
            Grade = 70,
            StudentId = StudentSeed.LaibaKhawar.Id,
            AssignmentId = AssignmentSeed.EmbedA1.Id
        };
        public static Result R8 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.LaibaKhawar.Id,
            AssignmentId = AssignmentSeed.DBSMA1.Id
        };
        public static Result R9 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.LaibaKhawar.Id,
            AssignmentId = AssignmentSeed.AlgoA1.Id
        };
        #endregion
        
        #region Guy Morley
        public static Result R10 { get; } = new Result()
        {
            Grade = 50,
            StudentId = StudentSeed.GuyMorley.Id,
            AssignmentId = AssignmentSeed.DBSMA2.Id
        };
        public static Result R11 { get; } = new Result()
        {
            Grade = 60,
            StudentId = StudentSeed.GuyMorley.Id,
            AssignmentId = AssignmentSeed.CyberA2.Id
        };
        #endregion
        
        #region Emilia Chapman
        public static Result R12 { get; } = new Result()
        {
            Grade = 90,
            StudentId = StudentSeed.EmiliaChapman.Id,
            AssignmentId = AssignmentSeed.DBSMA2.Id
        };
        public static Result R13 { get; } = new Result()
        {
            Grade = 85,
            StudentId = StudentSeed.EmiliaChapman.Id,
            AssignmentId = AssignmentSeed.CyberA2.Id
        };
        #endregion
        
        #region Jacob Smith
        public static Result R14 { get; } = new Result()
        {
            Grade = 30,
            StudentId = StudentSeed.JacobSmith.Id,
            AssignmentId = AssignmentSeed.AlgoA1.Id
        };
        public static Result R15 { get; } = new Result()
        {
            Grade = 40,
            StudentId = StudentSeed.JacobSmith.Id,
            AssignmentId = AssignmentSeed.GraphicsA3.Id
        };
        #endregion
        
        #region Yousef Good
        public static Result R16 { get; } = new Result()
        {
            Grade = 70,
            StudentId = StudentSeed.YousefGood.Id,
            AssignmentId = AssignmentSeed.AlgoA2.Id
        };
        public static Result R17 { get; } = new Result()
        {
            Grade = 75,
            StudentId = StudentSeed.YousefGood.Id,
            AssignmentId = AssignmentSeed.GraphicsA4.Id
        };
        #endregion
        
        #region Landen Pate
        public static Result R18 { get; } = new Result()
        {
            Grade = 70,
            StudentId = StudentSeed.LandenPate.Id,
            AssignmentId = AssignmentSeed.TrainFormA1.Id
        };
        public static Result R19 { get; } = new Result()
        {
            Grade = 75,
            StudentId = StudentSeed.LandenPate.Id,
            AssignmentId = AssignmentSeed.FirstAidA1.Id
        };
        #endregion
        
        #region Nicole Richards
        public static Result R20 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.NicoleRichards.Id,
            AssignmentId = AssignmentSeed.TrainFormA2.Id
        };
        public static Result R21 { get; } = new Result()
        {
            Grade = 65,
            StudentId = StudentSeed.NicoleRichards.Id,
            AssignmentId = AssignmentSeed.FirstAidA2.Id
        };
        #endregion
        
        #region Diana Rodriguez
        public static Result R22 { get; } = new Result()
        {
            Grade = 85,
            StudentId = StudentSeed.DianaRodriguez.Id,
            AssignmentId = AssignmentSeed.TrainFormA2.Id
        };
        public static Result R23 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.DianaRodriguez.Id,
            AssignmentId = AssignmentSeed.FirstAidA2.Id
        };
        #endregion
        
        #region Halle Hoffman
        public static Result R24 { get; } = new Result()
        {
            Grade = 85,
            StudentId = StudentSeed.HalleHoffman.Id,
            AssignmentId = AssignmentSeed.FirstAidA1.Id
        };
        public static Result R25 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.HalleHoffman.Id,
            AssignmentId = AssignmentSeed.EMHA1.Id
        };
        public static Result R26 { get; } = new Result()
        {
            Grade = 60,
            StudentId = StudentSeed.HalleHoffman.Id,
            AssignmentId = AssignmentSeed.RespA1.Id
        };
        #endregion
        
        #region Tyler Brooks
        public static Result R27 { get; } = new Result()
        {
            Grade = 30,
            StudentId = StudentSeed.TylerBrooks.Id,
            AssignmentId = AssignmentSeed.FirstAidA1.Id
        };
        public static Result R28 { get; } = new Result()
        {
            Grade = 80,
            StudentId = StudentSeed.TylerBrooks.Id,
            AssignmentId = AssignmentSeed.EMHA1.Id
        };
        public static Result R29 { get; } = new Result()
        {
            Grade = 85,
            StudentId = StudentSeed.TylerBrooks.Id,
            AssignmentId = AssignmentSeed.RespA1.Id
        };
        #endregion
        
        #region Max Moisio
        public static Result R30 { get; } = new Result()
        {
            Grade = 85,
            StudentId = StudentSeed.MaxMoisio.Id,
            AssignmentId = AssignmentSeed.ShakeA3.Id
        };
        public static Result R31 { get; } = new Result()
        {
            Grade = 90,
            StudentId = StudentSeed.MaxMoisio.Id,
            AssignmentId = AssignmentSeed.MarloweA3.Id
        };
        #endregion
        
        #region Joe Kaufman
        public static Result R32 { get; } = new Result()
        {
            Grade = 60,
            StudentId = StudentSeed.JoeKaufman.Id,
            AssignmentId = AssignmentSeed.ShakeA3.Id
        };
        public static Result R33 { get; } = new Result()
        {
            Grade = 50,
            StudentId = StudentSeed.JoeKaufman.Id,
            AssignmentId = AssignmentSeed.MarloweA3.Id
        };
        #endregion
        
        #region Eve Kennedy
        public static Result R34 { get; } = new Result()
        {
            Grade = 95,
            StudentId = StudentSeed.EveKennedy.Id,
            AssignmentId = AssignmentSeed.ShakeA2.Id
        };
        public static Result R35 { get; } = new Result()
        {
            Grade = 60,
            StudentId = StudentSeed.EveKennedy.Id,
            AssignmentId = AssignmentSeed.MarloweA2.Id
        };
        #endregion

        public static Result[] ToArray()
        {
            return new[]
            {
                R1,
                R2,
                R3,
                R4,
                R5,
                R6,
                R7,
                R8,
                R9,
                R10,
                R11,
                R12,
                R13,
                R14,
                R15,
                R16,
                R17,
                R18,
                R19,
                R20,
                R21,
                R22,
                R23,
                R24,
                R25,
                R26,
                R27,
                R28,
                R29,
                R30,
                R31,
                R32,
                R33,
                R34,
                R35
            };
        }
    }
}