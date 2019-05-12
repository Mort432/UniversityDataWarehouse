using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class LecturersViewModel : FactChartViewModelBase<LecturerFact>
    {
        private LecturerDim _lecturerDim;
        private IEnumerable<LecturerDim> _lecturerDims;

        private ILecturerDimService _lecturerDimService;

        public LecturersViewModel(ILecturerFactService lecturerFactService, ILecturerDimService lecturerDimService) :
            base(lecturerFactService)
        {
            _lecturerDimService = lecturerDimService;
        }
        

        public LecturerDim LecturerDim
        {
            get => _lecturerDim;
            set
            {
                if (!SetProperty(ref _lecturerDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<LecturerFact, bool>> expression = x => x.LecturerDimId == _lecturerDim.Id;

                Filters[typeof(LecturerDim)] = _lecturerDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<LecturerDim> LecturerDims
        {
            get => _lecturerDims;
            private set => SetProperty(ref _lecturerDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            LecturerDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            LecturerDims = _lecturerDimService.GetAsync().Result;
        }
    }
}