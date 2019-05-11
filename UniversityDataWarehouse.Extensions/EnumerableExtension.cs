using System;
using System.Collections.Generic;
using System.Linq;
using LiveCharts.Defaults;
using UniversityDataWarehouse.Data.Entities.Dimensional;

namespace UniversityDataWarehouse.Extensions
{
    public static class EnumerableExtension
    {
        public static IEnumerable<ObservablePoint> AsObservablePoints<TFact>(this IEnumerable<TFact> facts)
            where TFact : IFact
        {
            if(facts == null) throw new ArgumentNullException(nameof(facts));

            return facts
                .GroupBy(fact => fact.AcademicYearDim)
                .ToDictionary(
                    x => x.Key,
                    x => x.Sum(fact => fact.Value)
                ).AsObservablePoints(dim => dim.Year);
        }
    }
}