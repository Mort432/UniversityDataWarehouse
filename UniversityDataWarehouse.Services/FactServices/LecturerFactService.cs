using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class LecturerFactService : FactServiceBase<LecturerFact>, ILecturerFactService
    {
        protected override DbSet<LecturerFact> GetDbSet(OracleContext context)
        {
            return context.LecturerFacts;
        }

        protected override IQueryable<LecturerFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.LecturerDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.LecturerDimId);
        }
    }
}