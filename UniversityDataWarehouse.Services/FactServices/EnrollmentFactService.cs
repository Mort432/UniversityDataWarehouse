using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class EnrollmentFactService : FactServiceBase<EnrollmentFact>, IEnrollmentFactService
    {
        protected override DbSet<EnrollmentFact> GetDbSet(OracleContext context)
        {
            return context.EnrollmentFacts;
        }

        protected override IQueryable<EnrollmentFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}