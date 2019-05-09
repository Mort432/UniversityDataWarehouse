using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.Services;

namespace UniversityDataWarehouse.WPF.ViewModels
{
    public class LoginViewModel
    {
        private IAuthService _authService;
        private ISeedService _seedService;

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