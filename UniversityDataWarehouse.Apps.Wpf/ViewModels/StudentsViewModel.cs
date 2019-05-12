using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class StudentsViewModel : FactChartViewModelBase<StudentFact>
    {
        private CountryDim _countryDim;
        private IEnumerable<CountryDim> _countryDims;

        private ICountryDimService _countryDimService;

        public StudentsViewModel(IStudentFactService studentFactService, ICountryDimService countryDimService) :
            base(studentFactService)
        {
            _countryDimService = countryDimService;
        }
        

        public CountryDim CountryDim
        {
            get => _countryDim;
            set
            {
                if (!SetProperty(ref _countryDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<StudentFact, bool>> expression = x => x.CountryDimId == _countryDim.Id;

                Filters[typeof(CountryDim)] = _countryDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<CountryDim> CountryDims
        {
            get => _countryDims;
            private set => SetProperty(ref _countryDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            CountryDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            CountryDims = _countryDimService.GetAsync().Result;
        }
    }
}