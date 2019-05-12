using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Helpers;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Extensions;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
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
            IEnumerable<TFact> facts;

            var filters = Filters.Values.Where(filter => filter != null).ToList();

            switch (filters.Count)
            {
                case 0:
                    facts = await _factService.GetAsync();
                    break;
                case 1:
                    facts = await _factService.GetAsync(filters.Single());
                    break;
                default:
                    var parameterExpression = Expression.Parameter(typeof(TFact));
                    facts = await _factService.GetAsync(filters.Aggregate((x, y) => Expression.Lambda<Func<TFact, bool>>(Expression.AndAlso(x, y), parameterExpression)));
                    break;
            }

            return facts.AsObservablePoints().AsChartValues().AsColumnSeries().AsSeriesCollection();
        }
    }
}