using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class GenderDimService : DimServiceBase<GenderDim>, IGenderDimService
    {
        protected override DbSet<GenderDim> GetDbSet(OracleContext context)
        {
            return context.GenderDims;
        }

        protected override IQueryable<GenderDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Gender);
        }
    }
}