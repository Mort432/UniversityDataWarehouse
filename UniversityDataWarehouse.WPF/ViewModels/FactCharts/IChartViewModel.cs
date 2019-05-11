using LiveCharts;

namespace UniversityDataWarehouse.WPF.ViewModels.FactCharts
{
    public interface IChartViewModel
    {
        SeriesCollection SeriesCollection { get; }
    }
}