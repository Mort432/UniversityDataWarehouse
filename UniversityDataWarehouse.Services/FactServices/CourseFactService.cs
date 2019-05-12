using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class CourseFactService : FactServiceBase<CourseFact>, ICourseFactService
    {
        protected override DbSet<CourseFact> GetDbSet(OracleContext context)
        {
            return context.CourseFacts;
        }

        protected override IQueryable<CourseFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CampusDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.CampusDimId);
        }
    }
}