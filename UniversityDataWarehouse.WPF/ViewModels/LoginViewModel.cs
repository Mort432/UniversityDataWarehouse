using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.Services;

namespace UniversityDataWarehouse.WPF.ViewModels
{
    public class LoginViewModel
    {
        private IAuthService _authService;

        public LoginViewModel(IAuthService authService)
        {
            _authService = authService;
        }

        public bool Login(User user)
        {
            return _authService.Login(user);
        }
    }
}