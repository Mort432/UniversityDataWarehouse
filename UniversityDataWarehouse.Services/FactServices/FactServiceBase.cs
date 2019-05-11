using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public abstract class FactServiceBase<TFact> : ServiceBase<TFact>, IFactService<TFact> where TFact: class, IFact
    {
        public async Task<int> GetSumAsync()
        {
            using (var context = new OracleContext())
            {
                var dbSet = GetDbSet(context);

                if (!dbSet.Any()) return 0;

                return await dbSet.SumAsync(fact => fact.Value);
            }
        }

        public async Task<int> GetSumAsync(Expression<Func<TFact, bool>> filter)
        {
            using (var context = new OracleContext())
            {
                var dbSet = GetDbSet(context);

                if (!dbSet.Any(filter)) return 0;

                return await dbSet.Where(filter).SumAsync(fact => fact.Value);
            }
        }

        protected override IQueryable<TFact> GetQueryable(OracleContext context)
        {
            // TODO - Check if the include is needed or will be done automatically by the virtual members.
            return base.GetQueryable(context).Include(fact => fact.AcademicYearDim);
        }
    }
}