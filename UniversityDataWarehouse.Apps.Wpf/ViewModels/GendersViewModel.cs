using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class GendersViewModel : FactChartViewModelBase<GenderFact>
    {
        private GenderDim _genderDim;
        private IEnumerable<GenderDim> _genderDims;

        private IGenderDimService _genderDimService;

        public GendersViewModel(IGenderFactService genderFactService, IGenderDimService genderDimService) :
            base(genderFactService)
        {
            _genderDimService = genderDimService;
        }
        

        public GenderDim GenderDim
        {
            get => _genderDim;
            set
            {
                if (!SetProperty(ref _genderDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<GenderFact, bool>> expression = x => x.GenderDimId == _genderDim.Id;

                Filters[typeof(GenderDim)] = _genderDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<GenderDim> GenderDims
        {
            get => _genderDims;
            private set => SetProperty(ref _genderDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            GenderDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            GenderDims = _genderDimService.GetAsync().Result;
        }
    }
}