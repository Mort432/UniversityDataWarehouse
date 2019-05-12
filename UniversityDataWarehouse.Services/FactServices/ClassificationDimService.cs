using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class ClassificationDimService : DimServiceBase<ClassificationDim>, IClassificationDimService
    {
        protected override DbSet<ClassificationDim> GetDbSet(OracleContext context)
        {
            return context.ClassificationDims;
        }

        protected override IQueryable<ClassificationDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Classification);
        }
    }
}