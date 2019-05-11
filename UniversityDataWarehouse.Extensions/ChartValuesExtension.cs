using LiveCharts;
using LiveCharts.Definitions.Series;
using LiveCharts.Wpf;

namespace UniversityDataWarehouse.Extensions
{
    public static class ChartValuesExtension
    {
        public static ColumnSeries AsColumnSeries(this IChartValues values)
        {
            return values.AsSeriesView<ColumnSeries>();
        }

        public static LineSeries AsLineSeries(this IChartValues values)
        {
            return values.AsSeriesView<LineSeries>();
        }

        public static TSeriesView AsSeriesView<TSeriesView>(this IChartValues values) where TSeriesView : ISeriesView, new()
        {
            return new TSeriesView
            {
                Values = values
            };
        }
    }
}