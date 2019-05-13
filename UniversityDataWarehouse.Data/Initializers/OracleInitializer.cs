using System.Data.Entity.Migrations;
using System.Net.Mime;
using UniversityDataWarehouse.Data.Contexts;
using UniversityDataWarehouse.Data.Initializers.Seeds;

namespace UniversityDataWarehouse.Data.Initializers
{
    public class OracleInitializer : System.Data.Entity.CreateDatabaseIfNotExists<OracleContext>
    {
        //This class tells Entity Framework where our seed files are,
        //and to use them to add records to our operational database.
        //We do them in this order so that foreign keys can be established.
        protected override async void Seed(OracleContext context)
        {
            //System-specific
            context.Users.AddOrUpdate(UserSeed.ToArray());
            await context.SaveChangesAsync();
            
            context.Permissions.AddOrUpdate(PermissionSeed.ToArray());
            await context.SaveChangesAsync();
            
            //Operational
            context.Campuses.AddOrUpdate(CampusSeed.ToArray());
            await context.SaveChangesAsync();
            context.Countries.AddOrUpdate(CountrySeed.ToArray());
            await context.SaveChangesAsync();
            context.AcademicYears.AddOrUpdate(AcademicYearSeed.ToArray());
            await context.SaveChangesAsync();
            context.Modules.AddOrUpdate(ModuleSeed.ToArray());
            await context.SaveChangesAsync();
            context.Courses.AddOrUpdate(CourseSeed.ToArray());
            await context.SaveChangesAsync();
            context.CourseModules.AddOrUpdate(CourseModuleSeed.ToArray());
            await context.SaveChangesAsync();
            context.Lecturers.AddOrUpdate(LecturerSeed.ToArray());
            await context.SaveChangesAsync();
            context.ModuleRuns.AddOrUpdate(ModuleRunSeed.ToArray());
            await context.SaveChangesAsync();
            context.Students.AddOrUpdate(StudentSeed.ToArray());
            await context.SaveChangesAsync();
            context.Enrollments.AddOrUpdate(EnrollmentSeed.ToArray());
            await context.SaveChangesAsync();
            context.Assignments.AddOrUpdate(AssignmentSeed.ToArray());
            await context.SaveChangesAsync();
            context.Results.AddOrUpdate(ResultSeed.ToArray());
            await context.SaveChangesAsync();
            context.Graduations.AddOrUpdate(GraduationSeed.ToArray());
            await context.SaveChangesAsync();
            context.Complaints.AddOrUpdate(ComplaintSeed.ToArray());
            await context.SaveChangesAsync();
        }

        public void AttemptSeed(OracleContext context)
        {
            Seed(context);
        }
    }
}