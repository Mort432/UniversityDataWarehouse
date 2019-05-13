using System.Linq;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Entities;
using static BCrypt.Net.BCrypt;

namespace UniversityDataWarehouse.Services
{
    //Hey look, it's an AuthService, because I'm too lazy to learn OAuth!
    //Yeah, it's pretty standard. There's a login function. And a logout function I never used.
    //Oof.
    public class AuthService : IAuthService
    {
        public User AuthorizedUser { get; set; }

        //This takes a plaintext username and password from the front-end and uses the username to retrieve a user object.
        //Then we verify the plaintext password against the hashed password locally.
        //I mean, it's reasonably secure. In theory sending hashed passwords over the internet is fiiiiine.
        //Of course, when that password is "Admin" or "Password" it stops being so secure. Sigh.
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