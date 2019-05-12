using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class CountryDimService : DimServiceBase<CountryDim>, ICountryDimService
    {
        protected override DbSet<CountryDim> GetDbSet(OracleContext context)
        {
            return context.CountryDims;
        }

        protected override IQueryable<CountryDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}