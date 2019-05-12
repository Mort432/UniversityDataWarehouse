using LiveCharts;

namespace UniversityDataWarehouse.Apps.WPF.ViewModels.FactCharts
{
    public interface IChartViewModel
    {
        SeriesCollection SeriesCollection { get; }
    }
}