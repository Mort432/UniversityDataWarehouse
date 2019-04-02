using System.Data.Entity.Migrations;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Initializers.Seeds;

namespace UniversityDataWarehouse.Data.Initializers
{
    public class OracleInitializer : System.Data.Entity.CreateDatabaseIfNotExists<OracleContext>
    {
        protected override async void Seed(OracleContext context)
        {
            context.Users.AddOrUpdate(UserSeed.ToArray());
            await context.SaveChangesAsync();
            
            context.Permissions.AddOrUpdate(PermissionSeed.ToArray());
            await context.SaveChangesAsync();
        }
    }
}