using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class AssignmentSeed
    {
        public static Assignment DBSMA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.DBSMRun1.Id
        };
        
        public static Assignment DBSMA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.DBSMRun2.Id
        };
        
        public static Assignment CyberA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.CyberRun1.Id
        };
        
        public static Assignment CyberA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.CyberRun2.Id
        };
        
        public static Assignment CyberA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.CyberRun3.Id
        };
        
        public static Assignment EmbedA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.EmbedRun1.Id
        };
        
        public static Assignment EmbedA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.EmbedRun2.Id
        };
        
        public static Assignment EmbedA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.EmbedRun3.Id
        };
        
        public static Assignment ShakeA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.ShakespeareRun1.Id
        };
        
        public static Assignment ShakeA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.ShakespeareRun2.Id
        };
        
        public static Assignment ShakeA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.ShakespeareRun3.Id
        };
        
        public static Assignment MarloweA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.MarloweRun1.Id
        };
        
        public static Assignment MarloweA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.MarloweRun2.Id
        };
        
        public static Assignment MarloweA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.MarloweRun3.Id
        };
        
        public static Assignment FirstAidA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.FirstAidRun1.Id
        };
        
        public static Assignment FirstAidA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.FirstAidRun2.Id
        };
        
        public static Assignment FirstAidA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.FirstAidRun3.Id
        };
        
        public static Assignment FirstAidA4 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.FirstAidRun4.Id
        };
        
        public static Assignment FirstAidA5 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.FirstAidRun5.Id
        };
        
        public static Assignment RespA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.RespHealthRun1.Id
        };
        
        public static Assignment RespA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.RespHealthRun2.Id
        };
        
        public static Assignment RespA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.RespHealthRun3.Id
        };
        
        public static Assignment EMHA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.EMHRun1.Id
        };
        
        public static Assignment EMHA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.EMHRun2.Id
        };
        
        public static Assignment EMHA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.EMHRun3.Id
        };
        
        public static Assignment TrainFormA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.TrainingFormRun1.Id
        };
        
        public static Assignment TrainFormA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.TrainingFormRun2.Id
        };
        
        public static Assignment TrainFormA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.TrainingFormRun3.Id
        };
        
        public static Assignment GraphicsA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.GraphicsRun1.Id
        };
        
        public static Assignment GraphicsA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.GraphicsRun2.Id
        };
        
        public static Assignment GraphicsA3 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.GraphicsRun3.Id
        };
        
        public static Assignment GraphicsA4 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.GraphicsRun4.Id
        };
        
        public static Assignment AlgoA1 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.AlgoRun1.Id
        };
        
        public static Assignment AlgoA2 { get; } = new Assignment()
        {
            Title = "Write an essay or something.",
            ModuleRunId = ModuleRunSeed.AlgoRun1.Id
        };

        public static Assignment[] ToArray()
        {
            return new[]
            {
                DBSMA1,
                DBSMA2,
                CyberA1,
                CyberA2,
                CyberA3,
                EmbedA1,
                EmbedA2,
                EmbedA3,
                ShakeA1,
                ShakeA2,
                ShakeA3,
                MarloweA1,
                MarloweA2,
                MarloweA3,
                FirstAidA1,
                FirstAidA2,
                FirstAidA3,
                FirstAidA4,
                FirstAidA5,
                RespA1,
                RespA2,
                RespA3,
                EMHA1,
                EMHA2,
                EMHA3,
                TrainFormA1,
                TrainFormA2,
                TrainFormA3,
                GraphicsA1,
                GraphicsA2,
                GraphicsA3,
                GraphicsA4,
                AlgoA1,
                AlgoA2
            };
        }
    }
}