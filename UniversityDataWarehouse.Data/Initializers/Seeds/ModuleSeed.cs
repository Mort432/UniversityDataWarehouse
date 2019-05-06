using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class ModuleSeed
    {
        public static Module DatabaseSystemsModule { get; } = new Module()
        {
            Name = "Database Systems"
        };
        
        public static Module CyberSecurityModule { get; } = new Module()
        {
            Name = "Cyber Security"
        };
        
        public static Module EmbeddedSystemsModule { get; } = new Module()
        {
            Name = "Embedded Systems"
        };
        
        public static Module ShakespeareanPlaysModule { get; } = new Module()
        {
            Name = "Shakespearean Plays"
        };
        
        public static Module MarloweModule { get; } = new Module()
        {
            Name = "The Literary Work of Marlowe"
        };
        
        public static Module FirstAidModule { get; } = new Module()
        {
            Name = "First Aid"
        };
        
        public static Module RespiratoryHealthModule { get; } = new Module()
        {
            Name = "Respiratory Health"
        };
        
        public static Module ExerciseAndMentalHealthModule { get; } = new Module()
        {
            Name = "Exercise and Mental Health"
        };

        public static Module TrainingFormModule { get; } = new Module()
        {
            Name = "Good Training Form"
        };
        
        public static Module GraphicsEnginesModule { get; } = new Module()
        {
            Name = "Computer Graphics Engines"
        };
        
        public static Module AlgorithmsModule { get; } = new Module()
        {
            Name = "Software Algorithms"
        };

        public static Module[] ToArray()
        {
            return new[]
            {
                DatabaseSystemsModule,
                CyberSecurityModule,
                EmbeddedSystemsModule,
                ShakespeareanPlaysModule,
                MarloweModule,
                FirstAidModule,
                RespiratoryHealthModule,
                ExerciseAndMentalHealthModule,
                TrainingFormModule,
                GraphicsEnginesModule,
                AlgorithmsModule
            };
        }
    }
}