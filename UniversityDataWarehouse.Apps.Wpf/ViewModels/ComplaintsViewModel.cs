using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class ComplaintsViewModel : FactChartViewModelBase<ComplaintFact>
    {
        private CourseDim _courseDim;
        private IEnumerable<CourseDim> _courseDims;

        private ICourseDimService _courseDimService;

        public ComplaintsViewModel(IComplaintFactService complaintFactService, ICourseDimService courseDimService) :
            base(complaintFactService)
        {
            _courseDimService = courseDimService;
        }
        

        public CourseDim CourseDim
        {
            get => _courseDim;
            set
            {
                if (!SetProperty(ref _courseDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<ComplaintFact, bool>> expression = x => x.CourseDimId == _courseDim.Id;

                Filters[typeof(CourseDim)] = _courseDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<CourseDim> CourseDims
        {
            get => _courseDims;
            private set => SetProperty(ref _courseDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            CourseDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            CourseDims = _courseDimService.GetAsync().Result;
        }
    }
}