using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class CourseDimService : DimServiceBase<CourseDim>, ICourseDimService
    {
        protected override DbSet<CourseDim> GetDbSet(OracleContext context)
        {
            return context.CourseDims;
        }

        protected override IQueryable<CourseDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}