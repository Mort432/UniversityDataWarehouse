using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Services.FactServices
{
    public interface IFactService<TFact> : IService<TFact> where TFact: IFact
    {
        Task<int> GetSumAsync();

        Task<int> GetSumAsync(Expression<Func<TFact, bool>> filter);
    }
}