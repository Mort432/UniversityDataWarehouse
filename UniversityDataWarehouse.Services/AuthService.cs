using UniversityDataWarehouse.Models;

namespace UniversityDataWarehouse.Services
{
    public class AuthService : IAuthService
    {
        public User AuthorizedUser { get; set; }

        public bool Login(User user)
        {
            //TODO: Real login logic
            AuthorizedUser = user;
            return true;
        }

        public void Logout()
        {
            //TODO: Real logout logic
            AuthorizedUser = null;
        }
    }
}