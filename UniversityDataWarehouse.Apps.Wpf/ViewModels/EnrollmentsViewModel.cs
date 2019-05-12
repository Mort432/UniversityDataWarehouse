using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class EnrollmentsViewModel : FactChartViewModelBase<EnrollmentFact>
    {
        private ModuleDim _moduleDim;
        private IEnumerable<ModuleDim> _moduleDims;

        private IModuleDimService _moduleDimService;

        public EnrollmentsViewModel(IEnrollmentFactService enrollmentFactService, IModuleDimService moduleDimService) :
            base(enrollmentFactService)
        {
            _moduleDimService = moduleDimService;
        }
        

        public ModuleDim ModuleDim
        {
            get => _moduleDim;
            set
            {
                if (!SetProperty(ref _moduleDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<EnrollmentFact, bool>> expression = x => x.ModuleDimId == _moduleDim.Id;

                Filters[typeof(ModuleDim)] = _moduleDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<ModuleDim> ModuleDims
        {
            get => _moduleDims;
            private set => SetProperty(ref _moduleDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            ModuleDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            ModuleDims = _moduleDimService.GetAsync().Result;
        }
    }
}