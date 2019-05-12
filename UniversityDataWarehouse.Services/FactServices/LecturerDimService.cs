using System.Data.Entity;
using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public class LecturerDimService : DimServiceBase<LecturerDim>, ILecturerDimService
    {
        protected override DbSet<LecturerDim> GetDbSet(OracleContext context)
        {
            return context.LecturerDims;
        }

        protected override IQueryable<LecturerDim> GetQueryable(OracleContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.FirstName);
        }
    }
}