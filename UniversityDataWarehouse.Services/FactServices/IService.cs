using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UniversityDataWarehouse.Services.FactServices
{
    public interface IService<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAsync();

        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter);
    }
}