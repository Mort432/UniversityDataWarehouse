using System.Collections.Generic;
using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Data.Initializers.Seeds
{
    public class UserSeed
    {
        public static User Admin { get; } = new User
        {
            Username = "Admin",
            Password = "$2a$10$hQSSx09vnQZ6.hV1ckenD.yyda52ykmd7K/dWJw5nLrvMjEgToPlS",
        };

        public static User Teacher { get; } = new User
        {
            Username = "Teacher",
            Password = "$2a$10$LAEx.7EUm86lrx8L1Z1ciOSNZC13vum0.JQ7Vh10kVtlvgxZuovou"
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