﻿namespace UniversityDataWarehouse.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "S1509508.AcademicYearDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.AcademicYears",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        AcademicYearStart = c.DateTime(nullable: false),
                        AcademicYearEnd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.AssignmentFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        ModuleDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.ModuleDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.ModuleDims", t => t.ModuleDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.ModuleDimId);
            
            CreateTable(
                "S1509508.ModuleDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.Assignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 2000),
                        ModuleRunId = c.Int(nullable: false),
                        ModuleRun_AcademicYearId = c.Int(),
                        ModuleRun_ModuleId = c.Int(),
                        ModuleRun_LecturerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1509508.ModuleRuns", t => new { t.ModuleRun_AcademicYearId, t.ModuleRun_ModuleId, t.ModuleRun_LecturerId })
                .Index(t => new { t.ModuleRun_AcademicYearId, t.ModuleRun_ModuleId, t.ModuleRun_LecturerId });
            
            CreateTable(
                "S1509508.ModuleRuns",
                c => new
                    {
                        AcademicYearId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                        LecturerId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearId, t.ModuleId, t.LecturerId })
                .ForeignKey("S1509508.Modules", t => t.ModuleId, cascadeDelete: true)
                .ForeignKey("S1509508.Lecturers", t => t.LecturerId, cascadeDelete: true)
                .ForeignKey("S1509508.AcademicYears", t => t.Id, cascadeDelete: true)
                .Index(t => t.ModuleId)
                .Index(t => t.LecturerId)
                .Index(t => t.Id);
            
            CreateTable(
                "S1509508.Enrollments",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        ModuleRunId = c.Int(nullable: false),
                        ModuleRun_AcademicYearId = c.Int(),
                        ModuleRun_ModuleId = c.Int(),
                        ModuleRun_LecturerId = c.Int(),
                    })
                .PrimaryKey(t => new { t.StudentId, t.ModuleRunId })
                .ForeignKey("S1509508.ModuleRuns", t => new { t.ModuleRun_AcademicYearId, t.ModuleRun_ModuleId, t.ModuleRun_LecturerId })
                .ForeignKey("S1509508.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => new { t.ModuleRun_AcademicYearId, t.ModuleRun_ModuleId, t.ModuleRun_LecturerId });
            
            CreateTable(
                "S1509508.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 2000),
                        LastName = c.String(maxLength: 2000),
                        Gender = c.String(maxLength: 2000),
                        CountryId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1509508.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("S1509508.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CountryId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "S1509508.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                        CampusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1509508.Campus", t => t.CampusId, cascadeDelete: true)
                .Index(t => t.CampusId);
            
            CreateTable(
                "S1509508.Campus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CampusName = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.Complaints",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComplaintText = c.String(maxLength: 2000),
                        CourseId = c.Int(nullable: false),
                        AcademicYearId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("S1509508.AcademicYears", t => t.AcademicYearId, cascadeDelete: true)
                .ForeignKey("S1509508.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.AcademicYearId);
            
            CreateTable(
                "S1509508.CourseModules",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.ModuleId })
                .ForeignKey("S1509508.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("S1509508.Modules", t => t.ModuleId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.ModuleId);
            
            CreateTable(
                "S1509508.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.Lecturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 2000),
                        LastName = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.Results",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        AssignmentId = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.AssignmentId })
                .ForeignKey("S1509508.Assignments", t => t.AssignmentId, cascadeDelete: true)
                .ForeignKey("S1509508.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.AssignmentId);
            
            CreateTable(
                "S1509508.CampusDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.ClassificationDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Classification = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.ComplaintFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        CourseDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.CourseDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.CourseDims", t => t.CourseDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.CourseDimId);
            
            CreateTable(
                "S1509508.CourseDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.CountryDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.EnrollmentFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        ModuleDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.ModuleDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.ModuleDims", t => t.ModuleDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.ModuleDimId);
            
            CreateTable(
                "S1509508.GenderDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gender = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.GenderFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        GenderDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.GenderDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.GenderDims", t => t.GenderDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.GenderDimId);
            
            CreateTable(
                "S1509508.GraduationFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        CourseDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.CourseDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.CourseDims", t => t.CourseDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.CourseDimId);
            
            CreateTable(
                "S1509508.Graduations",
                c => new
                    {
                        YearId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.YearId, t.UserId, t.CourseId })
                .ForeignKey("S1509508.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("S1509508.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("S1509508.AcademicYears", t => t.YearId, cascadeDelete: true)
                .Index(t => t.YearId)
                .Index(t => t.UserId)
                .Index(t => t.CourseId);
            
            CreateTable(
                "S1509508.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 2000),
                        Password = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.Permissions",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        PermissionType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.PermissionType })
                .ForeignKey("S1509508.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "S1509508.LecturerDims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 2000),
                        LastName = c.String(maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "S1509508.LecturerFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        LecturerDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.LecturerDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.LecturerDims", t => t.LecturerDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.LecturerDimId);
            
            CreateTable(
                "S1509508.ModuleFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        CourseDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.CourseDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.CourseDims", t => t.CourseDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.CourseDimId);
            
            CreateTable(
                "S1509508.ResultFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        ModuleDimId = c.Int(nullable: false),
                        ClassificationDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.ModuleDimId, t.ClassificationDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.ClassificationDims", t => t.ClassificationDimId, cascadeDelete: true)
                .ForeignKey("S1509508.ModuleDims", t => t.ModuleDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.ModuleDimId)
                .Index(t => t.ClassificationDimId);
            
            CreateTable(
                "S1509508.StudentFacts",
                c => new
                    {
                        AcademicYearDimId = c.Int(nullable: false),
                        CountryDimId = c.Int(nullable: false),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademicYearDimId, t.CountryDimId })
                .ForeignKey("S1509508.AcademicYearDims", t => t.AcademicYearDimId, cascadeDelete: true)
                .ForeignKey("S1509508.CountryDims", t => t.CountryDimId, cascadeDelete: true)
                .Index(t => t.AcademicYearDimId)
                .Index(t => t.CountryDimId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("S1509508.StudentFacts", "CountryDimId", "S1509508.CountryDims");
            DropForeignKey("S1509508.StudentFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.ResultFacts", "ModuleDimId", "S1509508.ModuleDims");
            DropForeignKey("S1509508.ResultFacts", "ClassificationDimId", "S1509508.ClassificationDims");
            DropForeignKey("S1509508.ResultFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.ModuleFacts", "CourseDimId", "S1509508.CourseDims");
            DropForeignKey("S1509508.ModuleFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.LecturerFacts", "LecturerDimId", "S1509508.LecturerDims");
            DropForeignKey("S1509508.LecturerFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.Graduations", "YearId", "S1509508.AcademicYears");
            DropForeignKey("S1509508.Graduations", "UserId", "S1509508.Users");
            DropForeignKey("S1509508.Permissions", "UserId", "S1509508.Users");
            DropForeignKey("S1509508.Graduations", "CourseId", "S1509508.Courses");
            DropForeignKey("S1509508.GraduationFacts", "CourseDimId", "S1509508.CourseDims");
            DropForeignKey("S1509508.GraduationFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.GenderFacts", "GenderDimId", "S1509508.GenderDims");
            DropForeignKey("S1509508.GenderFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.EnrollmentFacts", "ModuleDimId", "S1509508.ModuleDims");
            DropForeignKey("S1509508.EnrollmentFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.ComplaintFacts", "CourseDimId", "S1509508.CourseDims");
            DropForeignKey("S1509508.ComplaintFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropForeignKey("S1509508.Results", "StudentId", "S1509508.Students");
            DropForeignKey("S1509508.Results", "AssignmentId", "S1509508.Assignments");
            DropForeignKey("S1509508.ModuleRuns", "Id", "S1509508.AcademicYears");
            DropForeignKey("S1509508.ModuleRuns", "LecturerId", "S1509508.Lecturers");
            DropForeignKey("S1509508.Enrollments", "StudentId", "S1509508.Students");
            DropForeignKey("S1509508.Students", "CourseId", "S1509508.Courses");
            DropForeignKey("S1509508.ModuleRuns", "ModuleId", "S1509508.Modules");
            DropForeignKey("S1509508.CourseModules", "ModuleId", "S1509508.Modules");
            DropForeignKey("S1509508.CourseModules", "CourseId", "S1509508.Courses");
            DropForeignKey("S1509508.Complaints", "CourseId", "S1509508.Courses");
            DropForeignKey("S1509508.Complaints", "AcademicYearId", "S1509508.AcademicYears");
            DropForeignKey("S1509508.Courses", "CampusId", "S1509508.Campus");
            DropForeignKey("S1509508.Students", "CountryId", "S1509508.Countries");
            DropForeignKey("S1509508.Enrollments", new[] { "ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId" }, "S1509508.ModuleRuns");
            DropForeignKey("S1509508.Assignments", new[] { "ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId" }, "S1509508.ModuleRuns");
            DropForeignKey("S1509508.AssignmentFacts", "ModuleDimId", "S1509508.ModuleDims");
            DropForeignKey("S1509508.AssignmentFacts", "AcademicYearDimId", "S1509508.AcademicYearDims");
            DropIndex("S1509508.StudentFacts", new[] { "CountryDimId" });
            DropIndex("S1509508.StudentFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.ResultFacts", new[] { "ClassificationDimId" });
            DropIndex("S1509508.ResultFacts", new[] { "ModuleDimId" });
            DropIndex("S1509508.ResultFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.ModuleFacts", new[] { "CourseDimId" });
            DropIndex("S1509508.ModuleFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.LecturerFacts", new[] { "LecturerDimId" });
            DropIndex("S1509508.LecturerFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.Permissions", new[] { "UserId" });
            DropIndex("S1509508.Graduations", new[] { "CourseId" });
            DropIndex("S1509508.Graduations", new[] { "UserId" });
            DropIndex("S1509508.Graduations", new[] { "YearId" });
            DropIndex("S1509508.GraduationFacts", new[] { "CourseDimId" });
            DropIndex("S1509508.GraduationFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.GenderFacts", new[] { "GenderDimId" });
            DropIndex("S1509508.GenderFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.EnrollmentFacts", new[] { "ModuleDimId" });
            DropIndex("S1509508.EnrollmentFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.ComplaintFacts", new[] { "CourseDimId" });
            DropIndex("S1509508.ComplaintFacts", new[] { "AcademicYearDimId" });
            DropIndex("S1509508.Results", new[] { "AssignmentId" });
            DropIndex("S1509508.Results", new[] { "StudentId" });
            DropIndex("S1509508.CourseModules", new[] { "ModuleId" });
            DropIndex("S1509508.CourseModules", new[] { "CourseId" });
            DropIndex("S1509508.Complaints", new[] { "AcademicYearId" });
            DropIndex("S1509508.Complaints", new[] { "CourseId" });
            DropIndex("S1509508.Courses", new[] { "CampusId" });
            DropIndex("S1509508.Students", new[] { "CourseId" });
            DropIndex("S1509508.Students", new[] { "CountryId" });
            DropIndex("S1509508.Enrollments", new[] { "ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId" });
            DropIndex("S1509508.Enrollments", new[] { "StudentId" });
            DropIndex("S1509508.ModuleRuns", new[] { "Id" });
            DropIndex("S1509508.ModuleRuns", new[] { "LecturerId" });
            DropIndex("S1509508.ModuleRuns", new[] { "ModuleId" });
            DropIndex("S1509508.Assignments", new[] { "ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId" });
            DropIndex("S1509508.AssignmentFacts", new[] { "ModuleDimId" });
            DropIndex("S1509508.AssignmentFacts", new[] { "AcademicYearDimId" });
            DropTable("S1509508.StudentFacts");
            DropTable("S1509508.ResultFacts");
            DropTable("S1509508.ModuleFacts");
            DropTable("S1509508.LecturerFacts");
            DropTable("S1509508.LecturerDims");
            DropTable("S1509508.Permissions");
            DropTable("S1509508.Users");
            DropTable("S1509508.Graduations");
            DropTable("S1509508.GraduationFacts");
            DropTable("S1509508.GenderFacts");
            DropTable("S1509508.GenderDims");
            DropTable("S1509508.EnrollmentFacts");
            DropTable("S1509508.CountryDims");
            DropTable("S1509508.CourseDims");
            DropTable("S1509508.ComplaintFacts");
            DropTable("S1509508.ClassificationDims");
            DropTable("S1509508.CampusDims");
            DropTable("S1509508.Results");
            DropTable("S1509508.Lecturers");
            DropTable("S1509508.Modules");
            DropTable("S1509508.CourseModules");
            DropTable("S1509508.Complaints");
            DropTable("S1509508.Campus");
            DropTable("S1509508.Courses");
            DropTable("S1509508.Countries");
            DropTable("S1509508.Students");
            DropTable("S1509508.Enrollments");
            DropTable("S1509508.ModuleRuns");
            DropTable("S1509508.Assignments");
            DropTable("S1509508.ModuleDims");
            DropTable("S1509508.AssignmentFacts");
            DropTable("S1509508.AcademicYears");
            DropTable("S1509508.AcademicYearDims");
        }
    }
}
