using System;
using UniversityDataWarehouse.Data.Entities;

namespace UniversityDataWarehouse.Data.Repositories
{
    public class UserRepo
    {

        private string ConnectionString { get; } = "User Id=s1509508;Password=s1509508!;Data Source=apollo01.glos.ac.uk:1521/orcl";

        public bool TryAuthorizeUser(User user)
        {
            // TODO: End-to-end encryption/protection
            throw new NotImplementedException();
        }
    }
}