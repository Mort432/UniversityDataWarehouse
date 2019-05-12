using System.Threading.Tasks;
using ImTools;
using LiveCharts;
using Prism.Regions;

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

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);
            
            UpdateSeriesCollection();
        }

        protected abstract Task<SeriesCollection> GetSeriesCollection();
    }
}