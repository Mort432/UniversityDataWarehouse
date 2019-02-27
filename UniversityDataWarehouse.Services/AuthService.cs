using UniversityDataWarehouse.Models;

namespace UniversityDataWarehouse.Services
{
    public class AuthService : IAuthService
    {
        public User AuthorizedUser { get; set; }

        public void Login(User user)
        {
            //TODO: Real login logic
            AuthorizedUser = user;
        }

        public void Logout()
        {
            //TODO: Real logout logic
            AuthorizedUser = null;
        }
    }
}