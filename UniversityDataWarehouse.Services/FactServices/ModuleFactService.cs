using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class ModuleFactService : FactServiceBase<ModuleFact>, IModuleFactService
    {
        protected override DbSet<ModuleFact> GetDbSet(OracleContext context)
        {
            return context.ModuleFacts;
        }

        protected override IQueryable<ModuleFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CourseDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.CourseDimId);
        }
    }
}