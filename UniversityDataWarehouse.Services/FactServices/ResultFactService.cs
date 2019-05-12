using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class ResultFactService : FactServiceBase<ResultFact>, IResultFactService
    {
        protected override DbSet<ResultFact> GetDbSet(OracleContext context)
        {
            return context.ResultFacts;
        }

        protected override IQueryable<ResultFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .Include(fact => fact.ClassificationDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.ModuleDimId)
                .ThenBy(fact => fact.ClassificationDim);
        }
    }
}