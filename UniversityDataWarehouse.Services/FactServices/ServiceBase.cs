using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UniversityDataWarehouse.Data.Contexts;

namespace UniversityDataWarehouse.Services.FactServices
{
    //Okay, I'm not going to comment a million bloody services.
    //I'll comment the Assignment Fact Service and the Campus Dim Service so you can see what's going on.
    //Basically, we establish that all of our services have a way to:
    //1. Get all the data from a table.
    //2. Get data from that table WITH a LINQ To Entities query.
    //That's it.
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