using System.Threading.Tasks;
using LiveCharts;

namespace UniversityDataWarehouse.WPF.ViewModels.FactCharts
{
    public abstract class ChartViewModelBase : ViewModelBase, IChartViewModel
    {
        public SeriesCollection SeriesCollection { get; set; }

        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}