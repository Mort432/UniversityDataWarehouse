using System.Threading.Tasks;
using LiveCharts;
using Prism.Regions;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public abstract class ChartViewModelBase : ViewModelBase, IChartViewModel
    {
        private SeriesCollection _seriesCollection;

        public SeriesCollection SeriesCollection
        {
            get => _seriesCollection;
            private set => SetProperty(ref _seriesCollection, value);
        }

        protected async void UpdateSeriesCollection()
        {
            SeriesCollection = await GetSeriesCollection();
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
            
            UpdateSeriesCollection();
        }

        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}