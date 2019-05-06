using UniversityDataWarehouse.Data.Entities.Operational;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class CampusSeed
    {
        public static Campus ParkCampus { get; } = new Campus()
        {
            CampusName = "Park"
        };
        
        public static Campus OxstallsCampus { get; } = new Campus()
        {
            CampusName = "Oxstalls"
        };
        
        public static Campus FCHCampus { get; } = new Campus()
        {
            CampusName = "Francis Close Hall"
        };

        public static Campus[] ToArray()
        {
            return new[]
            {
                ParkCampus,
                OxstallsCampus,
                FCHCampus
            };
        }
    }
}