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
    // All of the chart behaviour extends from this base model.
    public abstract class FactChartViewModelBase<TFact> : ChartViewModelBase, IFactChartViewModel where TFact : IFact
    {
        // Presents an interface for a fact service (for retrieving facts).
        private IFactService<TFact> _factService { get; }
        // Presents an interface for storing all the filters that may be applicable to a fact.
        protected IDictionary<Type, Expression<Func<TFact, bool>>> Filters { get; }

        //Constructor for injection.
        protected FactChartViewModelBase(IFactService<TFact> factService)
        {
            _factService = factService;
            Filters = new Dictionary<Type, Expression<Func<TFact, bool>>>();
        }

        //Interprets the number of filters and chooses the correct course of action.
        protected override async Task<SeriesCollection> GetSeriesCollection()
        {
            IEnumerable<TFact> facts;

            var filters = Filters.Values.Where(filter => filter != null).ToList();

            switch (filters.Count)
            {
                case 0:
                    //If there are no filters being applied, just get every fact.
                    facts = await _factService.GetAsync();
                    break;
                case 1:
                    //If there is a single filter, get the facts and apply that filter.
                    facts = await _factService.GetAsync(filters.Single());
                    break;
                default:
                    //This applies special logic for when we have more than one filter.
                    //The CombineFilters function below explains more.
                    //This will absolutely break if we ever create a view with more than 2 filters.
                    facts = await _factService.GetAsync(CombineFilters(filters));
                    break;
            }

            return facts.AsObservablePoints().AsChartValues().AsColumnSeries().AsSeriesCollection();
        }

        //Take a collection of expressions (right now this will only process the first two because I'm a plum)
        //Manually visit and combine both expression predicates together into one logically correct predicate
        //Use that predicate to return the new, shiny, correct expression to pass to Linq for EF querying.
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