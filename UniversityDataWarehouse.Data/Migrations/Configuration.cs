
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace UniversityDataWarehouse.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<UniversityDataWarehouse.Data.Contexts.OracleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }
    } 
}