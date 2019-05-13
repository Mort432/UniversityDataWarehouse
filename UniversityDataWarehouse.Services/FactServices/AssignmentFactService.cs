using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class AssignmentFactService : FactServiceBase<AssignmentFact>, IAssignmentFactService
    {
        //Okay so here's an example of something fun. This function... gets the whole set.
        protected override DbSet<AssignmentFact> GetDbSet(OracleContext context)
        {
            return context.AssignmentFacts;
        }

        //This is where the real magic happens.
        //Entity Framework is a very clever thing.
        //You can prepare a Queryable like this. And then apply predicates (actually Expressions) to them.
        //Entity Framework will then happily compile you a shiny new SQL query.
        //It's so beautiful.
        protected override IQueryable<AssignmentFact> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.AcademicYearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}