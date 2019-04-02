using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.Data.Initializers;

namespace UniversityDataWarehouse.Data.Contexts
{
    public class OracleContext : DbContext
    {
        public OracleContext() : base("OracleContext")
        {
            Database.SetInitializer(new OracleInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("S1509508");
            
            //Force appropriate string lengths in Oracle
            bool Predicate(System.Reflection.PropertyInfo propertyInfo) =>
                propertyInfo.PropertyType == typeof(string) &&
                propertyInfo.GetCustomAttributes(typeof(MaxLengthAttribute), false).Length == 0;

            void ConfigurationAction(ConventionPrimitivePropertyConfiguration propertyConfiguration) =>
                propertyConfiguration.HasMaxLength(2000);

            modelBuilder
                .Properties()
                .Where(Predicate)
                .Configure(ConfigurationAction);
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}