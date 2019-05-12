using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class ComplaintFactService : FactServiceBase<ComplaintFact>, IComplaintFactService
    {
        protected override DbSet<ComplaintFact> GetDbSet(OracleContext context)
        {
            return context.ComplaintFacts;
        }

        protected override IQueryable<ComplaintFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CourseDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.CourseDimId);
        }
    }
}