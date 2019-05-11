using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UniversityDataWarehouse.Data.Contexts;

namespace UniversityDataWarehouse.Services.FactServices
{
    public abstract class ServiceBase<TEntity> : IService<TEntity> where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            using (var context = new OracleContext())
            {
                return await GetQueryable(context).ToListAsync();
            }
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new OracleContext())
            {
                return await GetQueryable(context).Where(filter).ToListAsync();
            }
        }

        protected virtual IQueryable<TEntity> GetQueryable(OracleContext context)
        {
            return GetDbSet(context);
        }

        protected abstract DbSet<TEntity> GetDbSet(OracleContext context);
    }
}