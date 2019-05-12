using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities;
using static BCrypt.Net.BCrypt;

namespace UniversityDataWarehouse.Services
{
    public class AuthService : IAuthService
    {
        public User AuthorizedUser { get; set; }

        public bool Login(User user)
        {
            using (var context = new OracleContext())
            {
                var selectedUser = context.Users.SingleOrDefault(x => x.Username == user.Username);
                if (selectedUser != null && Verify(user.Password, selectedUser.Password))
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