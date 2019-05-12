using System;
using System.Collections.Generic;
using System.Linq;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Helpers;
using UniversityDataWarehouse.Extensions;
using UniversityDataWarehouse.Apps.WPF.ViewModels.FactCharts;

namespace UniversityDataWarehouse.Apps.WPF.ViewModels.FactCharts
{
    public abstract class FactChartViewModelBase<TFact> : ChartViewModelBase, IFactChartViewModel where TFact : IFact
    {
        private IFactService<TFact> _factService { get; }
        protected IDictionary<Type, Expression<Func<TFact, bool>>> Filters { get; }

        protected FactChartViewModelBase(IFactService<TFact> factService)
        {
            _factService = factService;
            Filters = new Dictionary<Type, Expression<Func<TFact, bool>>>();
        }

        protected override async Task<SeriesCollection> GetSeriesCollection()
        {
            Task<IEnumerable<TFact>> GetFacts()
            {
                var filters = Filters.Values.Where(filter => filter != null).ToList();

                switch (filters.Count)
                {
                    case 0:
                        return _factService.GetAsync();
                    case 1:
                        return _factService.GetAsync(filters.Single());
                    default:
                        var parameterExpression = System.Linq.Expressions.Expression.Parameter(typeof(TFact));
                        return _factService.GetAsync(filters.Aggregate((x, y) => Expression.Lambda<Func<TFact, bool>>(Expression.AndAlso(x, y), parameterExpression)));
                }
            }

            var facts = await Task.Run(GetFacts);

            return facts.AsObservablePoints().AsChartValues().AsColumnSeries().AsSeriesCollection();
        }
    }
}