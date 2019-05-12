using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class StudentFactService : FactServiceBase<StudentFact>, IStudentFactService
    {
        protected override DbSet<StudentFact> GetDbSet(OracleContext context)
        {
            return context.StudentFacts;
        }

        protected override IQueryable<StudentFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CountryDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.CountryDimId);
        }
    }
}