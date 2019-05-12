using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Prism.Regions;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class ResultsViewModel : FactChartViewModelBase<ResultFact>
    {
        private ModuleDim _moduleDim;
        private IEnumerable<ModuleDim> _moduleDims;

        private IModuleDimService _moduleDimService;
        
        private ClassificationDim _classificationDim;
        private IEnumerable<ClassificationDim> _classificationDims;

        private IClassificationDimService _classificationDimService;

        public ResultsViewModel(IResultFactService resultFactService, IModuleDimService moduleDimService, IClassificationDimService classificationDimService) :
            base(resultFactService)
        {
            _moduleDimService = moduleDimService;
            _classificationDimService = classificationDimService;
        }
        
        // Module filter
        public ModuleDim ModuleDim
        {
            get => _moduleDim;
            set
            {
                if (!SetProperty(ref _moduleDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<ResultFact, bool>> expression = x => x.ModuleDimId == _moduleDim.Id;

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
        
        // Classification filter
        public ClassificationDim ClassificationDim
        {
            get => _classificationDim;
            set
            {
                if (!SetProperty(ref _classificationDim, value)) return;
                
                //Expression filter declaration
                Expression<Func<ResultFact, bool>> expression = x => x.ClassificationDimId == _classificationDim.Id;

                Filters[typeof(ClassificationDim)] = _classificationDim == null
                    ? null
                    : expression;
                
                UpdateSeriesCollection();
            }
        }

        public IEnumerable<ClassificationDim> ClassificationDims
        {
            get => _classificationDims;
            private set => SetProperty(ref _classificationDims, value);
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
            base.OnNavigatedFrom(navigationContext);

            ModuleDim = null;
            ClassificationDim = null;
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            base.OnNavigatedTo(navigationContext);

            ModuleDims = _moduleDimService.GetAsync().Result;
            ClassificationDims = _classificationDimService.GetAsync().Result;
        }
    }
}