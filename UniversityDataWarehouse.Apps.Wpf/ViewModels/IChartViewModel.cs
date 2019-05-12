using LiveCharts;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public interface IChartViewModel
    {
        SeriesCollection SeriesCollection { get; }
    }
}