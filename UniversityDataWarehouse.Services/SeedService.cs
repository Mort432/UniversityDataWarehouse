using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Initializers;

namespace UniversityDataWarehouse.Services
{
    public class SeedService : ISeedService
    {  
        //Whenever this is called, it attempts to run the seed to put data in the operational database.
        //First though, it checks if there's anything there. For our purposes, this lets us know if the seed
        //has already been run, so we can avoid inserting duplicate objects. Hooray.
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