using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class CampusDimService : DimServiceBase<CampusDim>, ICampusDimService
    {
        //Dim services are basically the same as Fact services, but slightly simpler.
        //Obviously, we can't Sum a dimension, so we don't have that functionaltiy on the DimServiceBase.
        protected override DbSet<CampusDim> GetDbSet(OracleContext context)
        {
            return context.CampusDims;
        }

        //In addition, there's never any additional joins (as we're not using the Snowflake schema) so
        //We can just do this to get a sorted queryable. Neat.
        protected override IQueryable<CampusDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}