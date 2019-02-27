using UniversityDataWarehouse.Models;

namespace UniversityDataWarehouse.Services
{
    public interface IAuthService
    {
        User AuthorizedUser { get; set; }
        void Login(User user);
        void Logout();
    }
}