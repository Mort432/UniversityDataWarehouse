using System.Collections.Generic;

namespace UniversityDataWarehouse.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public IEnumerable<Permission> Permissions { get; set; }
    }
}