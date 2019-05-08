using System.Dynamic;
using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class CountrySeed
    {
        public static Country UnitedKingdom { get; } = new Country()
        {
            Name = "United Kingdom"
        };
        
        public static Country France { get; } = new Country()
        {
            Name = "France"
        };
        
        public static Country UnitedStates { get; } = new Country()
        {
            Name = "United States"
        };
        
        public static Country Pakistan { get; } = new Country()
        {
            Name = "Pakistan"
        };
    }
}