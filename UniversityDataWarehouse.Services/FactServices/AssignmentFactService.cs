using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class AssignmentFactService : FactServiceBase<AssignmentFact>, IAssignmentFactService
    {
        protected override DbSet<AssignmentFact> GetDbSet(OracleContext context)
        {
            return context.AssignmentFacts;
        }

        protected override IQueryable<AssignmentFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}