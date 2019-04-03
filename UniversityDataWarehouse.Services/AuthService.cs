using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Services
{
    public class AuthService : IAuthService
    {
        public User AuthorizedUser { get; set; }

        public bool Login(User user)
        {
            //TODO: Secure login logic
            using (var context = new OracleContext())
            {
                var selectedUser = context.Users.SingleOrDefault(x => x.Username == user.Username);
                if (selectedUser != null && selectedUser.Password == user.Password)
                {
                    AuthorizedUser = user;
                    return true;
                }
                AuthorizedUser = null;
                return false;
            }
        }

        public void Logout()
        {
            //TODO: Real logout logic
            AuthorizedUser = null;
        }
    }
}