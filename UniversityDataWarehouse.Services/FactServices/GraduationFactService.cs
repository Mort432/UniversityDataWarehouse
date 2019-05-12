using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class GraduationFactService : FactServiceBase<GraduationFact>, IGraduationFactService
    {
        protected override DbSet<GraduationFact> GetDbSet(OracleContext context)
        {
            return context.GraduationFacts;
        }

        protected override IQueryable<GraduationFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CourseDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.CourseDimId);
        }
    }
}