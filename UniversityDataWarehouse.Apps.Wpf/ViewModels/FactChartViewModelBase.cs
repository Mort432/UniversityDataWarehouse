using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Helpers;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Extensions;
using UniversityDataWarehouse.Services.Expressions;
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
                    //This will absolutely break if we ever create a view with more than 2 filters.
                    facts = await _factService.GetAsync(CombineFilters(filters));
                    break;
            }

            return facts.AsObservablePoints().AsChartValues().AsColumnSeries().AsSeriesCollection();
        }

        private Expression<Func<TFact, bool>> CombineFilters(List<Expression<Func<TFact, bool>>> filters)
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(TFact));
            var leftExpression = filters[0];
            var rightExpression = filters[1];

            var leftVisitor = new ReplaceExpressionVisitor(leftExpression.Parameters[0], parameterExpression);
            var newLeftExpression = leftVisitor.Visit(leftExpression.Body);
            
            var rightVisitor = new ReplaceExpressionVisitor(rightExpression.Parameters[0], parameterExpression);
            var newRightExpression = rightVisitor.Visit(rightExpression.Body);

            return Expression.Lambda<Func<TFact, bool>>(Expression.AndAlso(newLeftExpression, newRightExpression),
                parameterExpression);
        }
    }
}