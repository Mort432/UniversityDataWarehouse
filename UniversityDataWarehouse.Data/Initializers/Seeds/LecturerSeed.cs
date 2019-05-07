using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class LecturerSeed
    {
        public static Lecturer AhsanIkram { get; } = new Lecturer()
        {
            FirstName = "Ahsan",
            LastName = "Ikram"
        };
        
        public static Lecturer AbuAlam { get; } = new Lecturer()
        {
            FirstName = "Abu",
            LastName = "Alam"
        };
        
        public static Lecturer JuliePaterson { get; } = new Lecturer()
        {
            FirstName = "Julie",
            LastName = "Paterson"
        };
        
        public static Lecturer TomWillis { get; } = new Lecturer()
        {
            FirstName = "Tom",
            LastName = "Willis"
        };
        
        public static Lecturer JudyHarper { get; } = new Lecturer()
        {
            FirstName = "Judy",
            LastName = "Harper"
        };
        
        public static Lecturer DominicForbes { get; } = new Lecturer()
        {
            FirstName = "Dominic",
            LastName = "Forbes"
        };
        
        public static Lecturer LydiaGrant { get; } = new Lecturer()
        {
            FirstName = "Lydia",
            LastName = "Grant"
        };
        
        public static Lecturer CallieMcClure { get; } = new Lecturer()
        {
            FirstName = "Callie",
            LastName = "McClure"
        };
        
        public static Lecturer NoahDoyle { get; } = new Lecturer()
        {
            FirstName = "Noah",
            LastName = "Doyle"
        };
        
        public static Lecturer SeanFoley { get; } = new Lecturer()
        {
            FirstName = "Sean",
            LastName = "Foley"
        };
        
        public static Lecturer CarmenRichards { get; } = new Lecturer()
        {
            FirstName = "Carmen",
            LastName = "Richards"
        };
        
        public static Lecturer KiranJoyner { get; } = new Lecturer()
        {
            FirstName = "Kiran",
            LastName = "Joyner"
        };

        public static Lecturer[] ToArray()
        {
            return new[]
            {
                AhsanIkram,
                AbuAlam,
                JuliePaterson,
                TomWillis,
                JudyHarper,
                DominicForbes,
                LydiaGrant,
                CallieMcClure,
                NoahDoyle,
                SeanFoley,
                CarmenRichards,
                KiranJoyner
            };
        }
        
    }
}