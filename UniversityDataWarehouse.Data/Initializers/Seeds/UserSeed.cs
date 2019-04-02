using System.Collections.Generic;
using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class UserSeed
    {
        public static User Admin { get; } = new User
        {
            Username = "Admin",
            Password = "Admin",
            
        };

        public static User Teacher { get; } = new User
        {
            Username = "Teacher",
            Password = "Teacher"
        };

        public static User[] ToArray()
        {
            return new[]
            {
                Admin,
                Teacher
            };
        }
    }
}