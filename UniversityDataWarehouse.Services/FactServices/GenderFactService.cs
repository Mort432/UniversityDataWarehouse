using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class GenderFactService : FactServiceBase<GenderFact>, IGenderFactService
    {
        protected override DbSet<GenderFact> GetDbSet(OracleContext context)
        {
            return context.GenderFacts;
        }

        protected override IQueryable<GenderFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.GenderDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.GenderDimId);
        }
    }
}