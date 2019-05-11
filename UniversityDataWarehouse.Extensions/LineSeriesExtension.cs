using LiveCharts;
using LiveCharts.Definitions.Series;

namespace UniversityDataWarehouse.Extensions
{
    public static class LineSeriesExtension
    {
        public static SeriesCollection AsSeriesCollection(this ISeriesView series)
        {
            return new SeriesCollection(series);
        }
    }
}