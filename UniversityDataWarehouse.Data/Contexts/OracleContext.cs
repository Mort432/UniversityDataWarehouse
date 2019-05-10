using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using UniversityDataWarehouse.Data.Entities;
using UniversityDataWarehouse.Data.Entities.Dimensional;
using UniversityDataWarehouse.Data.Entities.Operational;
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
        
        //System-specific
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        //Operational
        public DbSet<AcademicYear> AcademicYears { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseModule> CourseModules { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Graduation> Graduations { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<ModuleRun> ModuleRuns { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Student> Students { get; set; }
        //Dimensional
        public DbSet<AcademicYearDim> AcademicYearDims { get; set; }
        public DbSet<AssignmentFact> AssignmentFacts { get; set; }
        public DbSet<CampusDim> CampusDims { get; set; }
        public DbSet<ClassificationDim> ClassificationDims { get; set; }
        public DbSet<ComplaintFact> ComplaintFacts { get; set; }
        public DbSet<CountryDim> CountryDims { get; set; }
        public DbSet<CourseDim> CourseDims { get; set; }
        public DbSet<CourseFact> CourseFacts { get; set; }
        public DbSet<EnrollmentFact> EnrollmentFacts { get; set; }
        public DbSet<GenderDim> GenderDims { get; set; }
        public DbSet<GenderFact> GenderFacts { get; set; }
        public DbSet<GraduationFact> GraduationFacts { get; set; }
        public DbSet<LecturerDim> LecturerDims { get; set; }
        public DbSet<LecturerFact> LecturerFacts { get; set; }
        public DbSet<ModuleDim> ModuleDims { get; set; }
        public DbSet<ModuleFact> ModuleFacts { get; set; }
        public DbSet<ResultFact> ResultFacts { get; set; }
        public DbSet<StudentFact> StudentFacts { get; set; }
    }
}