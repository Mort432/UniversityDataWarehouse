using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Initializers;

namespace UniversityDataWarehouse.Services
{
    public class SeedService : ISeedService
    {  
        public void AttemptSeed()
        {
            using (var context = new OracleContext())
            {
                //If there's no data in the users table, we haven't run the seed yet.
                if (!context.Users.Any())
                {
                    //Execute the seed.
                    OracleInitializer initializer = new OracleInitializer();
                    initializer.AttemptSeed(context);
                }
            }
        }
    }
}