using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class ModuleDimService : DimServiceBase<ModuleDim>, IModuleDimService
    {
        protected override DbSet<ModuleDim> GetDbSet(OracleContext context)
        {
            return context.ModuleDims;
        }

        protected override IQueryable<ModuleDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}