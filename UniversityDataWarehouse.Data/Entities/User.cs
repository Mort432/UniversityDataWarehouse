using System.Collections.Generic;

namespace UniversityDataWarehouse.Data.Entities
{
    //Your bog standard data warehouse user.
    public class User : EntityBase
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}