using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class CampusDimService : DimServiceBase<CampusDim>, ICampusDimService
    {
        protected override DbSet<CampusDim> GetDbSet(OracleContext context)
        {
            return context.CampusDims;
        }

        protected override IQueryable<CampusDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}