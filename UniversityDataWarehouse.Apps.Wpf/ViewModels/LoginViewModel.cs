using Prism.Mvvm;
using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.Services;

namespace UniversityDataWarehouse.Apps.Wpf.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly IAuthService _authService;
        private readonly ISeedService _seedService;

        public LoginViewModel(IAuthService authService, ISeedService seedService)
        {
            _authService = authService;
            _seedService = seedService;
        }

        public bool Login(User user)
        {
            _seedService.AttemptSeed();
            return _authService.Login(user);
        }
    }
}