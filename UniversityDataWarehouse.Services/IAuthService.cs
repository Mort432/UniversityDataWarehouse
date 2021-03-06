using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Services
{
    public interface IAuthService
    {
        User AuthorizedUser { get; set; }
        bool Login(User user);
        void Logout();
    }
}