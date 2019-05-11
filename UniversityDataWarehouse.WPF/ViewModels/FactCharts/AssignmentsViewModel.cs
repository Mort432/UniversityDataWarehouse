using System.Collections.Generic;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Services.FactServices;

namespace UniversityDataWarehouse.WPF.ViewModels.FactCharts
{
    public class AssignmentsViewModel : FactChartViewModelBase<AssignmentFact>
    {
        private ModuleDim _moduleDim;
        private IEnumerable<ModuleDim> _moduleDims;

        private IModuleDimService _moduleDimService;

        public AssignmentsViewModel(IAssignmentFactService assignmentFactService, IModuleDimService moduleDimService) :
            base(assignmentFactService)
        {
            _moduleDimService = moduleDimService;
        }
        

        public ModuleDim ModuleDim
        {
            get => _moduleDim;
            set
            {
                if (!SetProperty(ref _moduleDim, value)) return;
            }
        }
    }
}