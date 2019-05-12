using System.Threading.Tasks;
using LiveCharts;

namespace UniversityDataWarehouse.Apps.WPF.ViewModels.FactCharts
{
    public abstract class ChartViewModelBase : ViewModelBase, IChartViewModel
    {
        private SeriesCollection _seriesCollection;

        public SeriesCollection SeriesCollection
        {
            get => _seriesCollection;
            private set => SetProperty(ref _seriesCollection, value);
        }

        protected void UpdateSeriesCollection()
        {
            SeriesCollection = GetSeriesCollection().Result;
        }

        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}