using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class CoursesViewModel : FactChartViewModelBase<CourseFact>
    {
        private CampusDim _campusDim;
        private IEnumerable<CampusDim> _campusDims;

        private ICampusDimService _campusDimService;

        public CoursesViewModel(ICourseFactService courseFactService, ICampusDimService campusDimService) :
            base(courseFactService)
        {
            _campusDimService = campusDimService;
        }
        

        public CampusDim CampusDim
        {
            get => _campusDim;
            set
            {
                if (!SetProperty(ref _campusDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<CourseFact, bool>> expression = x => x.CampusDimId == _campusDim.Id;

                Filters[typeof(CampusDim)] = _campusDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<CampusDim> CampusDims
        {
            get => _campusDims;
            private set => SetProperty(ref _campusDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            CampusDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            CampusDims = _campusDimService.GetAsync().Result;
        }
    }
}