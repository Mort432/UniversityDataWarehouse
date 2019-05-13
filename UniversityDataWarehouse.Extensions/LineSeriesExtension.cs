using LiveCharts;
using LiveCharts.Definitions.Series;

namespace UniversityDataWarehouse.Extensions
{
    // This extension class converts SeriesViews into SeriesCollections for LiveCharts consumption.
    public static class LineSeriesExtension
    {
        public static SeriesCollection AsSeriesCollection(this ISeriesView series)
        {
            return new SeriesCollection{series};
        }
    }
}