using System.Threading.Tasks;
using LiveCharts;

namespace UniversityDataWarehouse.WPF.ViewModels.FactCharts
{
    public abstract class ChartViewModelBase : IChartViewModel
    {
        public SeriesCollection SeriesCollection { get; set; }

        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}