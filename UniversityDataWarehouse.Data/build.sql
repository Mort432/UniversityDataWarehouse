create table "S1509508"."AcademicYearDims"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  constraint "PK_AcademicYearDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_AcademicYearDims"
/

create or replace trigger "S1509508"."TR_AcademicYearDims"
  before insert on "S1509508"."AcademicYearDims"
  for each row
begin
  select "S1509508"."SQ_AcademicYearDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."AcademicYears"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  "AcademicYearStart" date not null,
  "AcademicYearEnd" date not null,
  constraint "PK_AcademicYears" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_AcademicYears"
/

create or replace trigger "S1509508"."TR_AcademicYears"
  before insert on "S1509508"."AcademicYears"
  for each row
begin
  select "S1509508"."SQ_AcademicYears".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."AssignmentFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "ModuleDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_AssignmentFacts" primary key ("AcademicYearDimId", "ModuleDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_AssignmentFacts__1448872138" on "S1509508"."AssignmentFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_AssignmentFacts_ModuleDimId" on "S1509508"."AssignmentFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."ModuleDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_ModuleDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_ModuleDims"
/

create or replace trigger "S1509508"."TR_ModuleDims"
  before insert on "S1509508"."ModuleDims"
  for each row
begin
  select "S1509508"."SQ_ModuleDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."Assignments"
(
  "Id" number(10, 0) not null,
  "Title" nvarchar2(2000) null,
  "ModuleRunId" number(10, 0) not null,
  "ModuleRun_AcademicYearId" number(10, 0) null,
  "ModuleRun_ModuleId" number(10, 0) null,
  "ModuleRun_LecturerId" number(10, 0) null,
  constraint "PK_Assignments" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Assignments"
/

create or replace trigger "S1509508"."TR_Assignments"
  before insert on "S1509508"."Assignments"
  for each row
begin
  select "S1509508"."SQ_Assignments".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Assignments_Modu_2023938582" on "S1509508"."Assignments" ("ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."ModuleRuns"
(
  "AcademicYearId" number(10, 0) not null,
  "ModuleId" number(10, 0) not null,
  "LecturerId" number(10, 0) not null,
  "Id" number(10, 0) not null,
  constraint "PK_ModuleRuns" primary key ("AcademicYearId", "ModuleId", "LecturerId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_ModuleRuns_ModuleId" on "S1509508"."ModuleRuns" ("ModuleId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_ModuleRuns_LecturerId" on "S1509508"."ModuleRuns" ("LecturerId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_ModuleRuns_Id" on "S1509508"."ModuleRuns" ("Id")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Enrollments"
(
  "StudentId" number(10, 0) not null,
  "ModuleRunId" number(10, 0) not null,
  "ModuleRun_AcademicYearId" number(10, 0) null,
  "ModuleRun_ModuleId" number(10, 0) null,
  "ModuleRun_LecturerId" number(10, 0) null,
  constraint "PK_Enrollments" primary key ("StudentId", "ModuleRunId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_Enrollments_StudentId" on "S1509508"."Enrollments" ("StudentId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Enrollments_Modu_1648838737" on "S1509508"."Enrollments" ("ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Students"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  "Gender" nvarchar2(2000) null,
  "CountryId" number(10, 0) not null,
  "CourseId" number(10, 0) not null,
  constraint "PK_Students" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Students"
/

create or replace trigger "S1509508"."TR_Students"
  before insert on "S1509508"."Students"
  for each row
begin
  select "S1509508"."SQ_Students".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Students_CountryId" on "S1509508"."Students" ("CountryId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Students_CourseId" on "S1509508"."Students" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Countries"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Countries" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Countries"
/

create or replace trigger "S1509508"."TR_Countries"
  before insert on "S1509508"."Countries"
  for each row
begin
  select "S1509508"."SQ_Countries".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."Courses"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "CampusId" number(10, 0) not null,
  constraint "PK_Courses" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Courses"
/

create or replace trigger "S1509508"."TR_Courses"
  before insert on "S1509508"."Courses"
  for each row
begin
  select "S1509508"."SQ_Courses".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Courses_CampusId" on "S1509508"."Courses" ("CampusId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Campus"
(
  "Id" number(10, 0) not null,
  "CampusName" nvarchar2(2000) null,
  constraint "PK_Campus" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Campus"
/

create or replace trigger "S1509508"."TR_Campus"
  before insert on "S1509508"."Campus"
  for each row
begin
  select "S1509508"."SQ_Campus".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."Complaints"
(
  "Id" number(10, 0) not null,
  "ComplaintText" nvarchar2(2000) null,
  "CourseId" number(10, 0) not null,
  "AcademicYearId" number(10, 0) not null,
  constraint "PK_Complaints" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Complaints"
/

create or replace trigger "S1509508"."TR_Complaints"
  before insert on "S1509508"."Complaints"
  for each row
begin
  select "S1509508"."SQ_Complaints".nextval into :new."Id" from dual;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Complaints_CourseId" on "S1509508"."Complaints" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Complaints_AcademicYearId" on "S1509508"."Complaints" ("AcademicYearId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."CourseModules"
(
  "CourseId" number(10, 0) not null,
  "ModuleId" number(10, 0) not null,
  constraint "PK_CourseModules" primary key ("CourseId", "ModuleId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_CourseModules_CourseId" on "S1509508"."CourseModules" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_CourseModules_ModuleId" on "S1509508"."CourseModules" ("ModuleId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Modules"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Modules" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Modules"
/

create or replace trigger "S1509508"."TR_Modules"
  before insert on "S1509508"."Modules"
  for each row
begin
  select "S1509508"."SQ_Modules".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."Lecturers"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  constraint "PK_Lecturers" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Lecturers"
/

create or replace trigger "S1509508"."TR_Lecturers"
  before insert on "S1509508"."Lecturers"
  for each row
begin
  select "S1509508"."SQ_Lecturers".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."Results"
(
  "StudentId" number(10, 0) not null,
  "AssignmentId" number(10, 0) not null,
  "Grade" number(10, 0) not null,
  "Id" number(10, 0) not null,
  constraint "PK_Results" primary key ("StudentId", "AssignmentId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_Results_StudentId" on "S1509508"."Results" ("StudentId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Results_AssignmentId" on "S1509508"."Results" ("AssignmentId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."CampusDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CampusDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_CampusDims"
/

create or replace trigger "S1509508"."TR_CampusDims"
  before insert on "S1509508"."CampusDims"
  for each row
begin
  select "S1509508"."SQ_CampusDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."ClassificationDims"
(
  "Id" number(10, 0) not null,
  "Classification" nvarchar2(2000) null,
  constraint "PK_ClassificationDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_ClassificationDims"
/

create or replace trigger "S1509508"."TR_ClassificationDims"
  before insert on "S1509508"."ClassificationDims"
  for each row
begin
  select "S1509508"."SQ_ClassificationDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."ComplaintFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CourseDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_ComplaintFacts" primary key ("AcademicYearDimId", "CourseDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_ComplaintFacts_A_1386423654" on "S1509508"."ComplaintFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_ComplaintFacts_CourseDimId" on "S1509508"."ComplaintFacts" ("CourseDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."CourseDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CourseDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_CourseDims"
/

create or replace trigger "S1509508"."TR_CourseDims"
  before insert on "S1509508"."CourseDims"
  for each row
begin
  select "S1509508"."SQ_CourseDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."CountryDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CountryDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_CountryDims"
/

create or replace trigger "S1509508"."TR_CountryDims"
  before insert on "S1509508"."CountryDims"
  for each row
begin
  select "S1509508"."SQ_CountryDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."EnrollmentFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "ModuleDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_EnrollmentFacts" primary key ("AcademicYearDimId", "ModuleDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_EnrollmentFacts_A_177810579" on "S1509508"."EnrollmentFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_EnrollmentFacts_ModuleDimId" on "S1509508"."EnrollmentFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."GenderDims"
(
  "Id" number(10, 0) not null,
  "Gender" nvarchar2(2000) null,
  constraint "PK_GenderDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_GenderDims"
/

create or replace trigger "S1509508"."TR_GenderDims"
  before insert on "S1509508"."GenderDims"
  for each row
begin
  select "S1509508"."SQ_GenderDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."GenderFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "GenderDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_GenderFacts" primary key ("AcademicYearDimId", "GenderDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_GenderFacts_Acad_1333264266" on "S1509508"."GenderFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_GenderFacts_GenderDimId" on "S1509508"."GenderFacts" ("GenderDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."GraduationFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CourseDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_GraduationFacts" primary key ("AcademicYearDimId", "CourseDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_GraduationFacts_A_465991385" on "S1509508"."GraduationFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_GraduationFacts_CourseDimId" on "S1509508"."GraduationFacts" ("CourseDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Graduations"
(
  "YearId" number(10, 0) not null,
  "UserId" number(10, 0) not null,
  "CourseId" number(10, 0) not null,
  "Id" number(10, 0) not null,
  constraint "PK_Graduations" primary key ("YearId", "UserId", "CourseId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_Graduations_YearId" on "S1509508"."Graduations" ("YearId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Graduations_UserId" on "S1509508"."Graduations" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_Graduations_CourseId" on "S1509508"."Graduations" ("CourseId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."Users"
(
  "Id" number(10, 0) not null,
  "Username" nvarchar2(2000) null,
  "Password" nvarchar2(2000) null,
  constraint "PK_Users" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_Users"
/

create or replace trigger "S1509508"."TR_Users"
  before insert on "S1509508"."Users"
  for each row
begin
  select "S1509508"."SQ_Users".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."Permissions"
(
  "UserId" number(10, 0) not null,
  "PermissionType" number(10, 0) not null,
  constraint "PK_Permissions" primary key ("UserId", "PermissionType")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_Permissions_UserId" on "S1509508"."Permissions" ("UserId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."LecturerDims"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  constraint "PK_LecturerDims" primary key ("Id")
) segment creation immediate
/

create sequence "S1509508"."SQ_LecturerDims"
/

create or replace trigger "S1509508"."TR_LecturerDims"
  before insert on "S1509508"."LecturerDims"
  for each row
begin
  select "S1509508"."SQ_LecturerDims".nextval into :new."Id" from dual;
end;
/

create table "S1509508"."LecturerFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "LecturerDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_LecturerFacts" primary key ("AcademicYearDimId", "LecturerDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_LecturerFacts_Aca_925118121" on "S1509508"."LecturerFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_LecturerFacts_LecturerDimId" on "S1509508"."LecturerFacts" ("LecturerDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."ModuleFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CourseDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_ModuleFacts" primary key ("AcademicYearDimId", "CourseDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_ModuleFacts_Acad_2060256043" on "S1509508"."ModuleFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_ModuleFacts_CourseDimId" on "S1509508"."ModuleFacts" ("CourseDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."ResultFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "ModuleDimId" number(10, 0) not null,
  "ClassificationDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_ResultFacts" primary key ("AcademicYearDimId", "ModuleDimId", "ClassificationDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_ResultFacts_Acad_1508787010" on "S1509508"."ResultFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_ResultFacts_ModuleDimId" on "S1509508"."ResultFacts" ("ModuleDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_ResultFacts_Clas_1227287608" on "S1509508"."ResultFacts" ("ClassificationDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

create table "S1509508"."StudentFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CountryDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_StudentFacts" primary key ("AcademicYearDimId", "CountryDimId")
) segment creation immediate
/

begin
  execute immediate
    'create index "S1509508"."IX_StudentFacts_Aca_1313936632" on "S1509508"."StudentFacts" ("AcademicYearDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

begin
  execute immediate
    'create index "S1509508"."IX_StudentFacts_CountryDimId" on "S1509508"."StudentFacts" ("CountryDimId")';
exception
  when others then
    if sqlcode <> -1408 then
      raise;
    end if;
end;
/

alter table "S1509508"."AssignmentFacts" add constraint "FK_AssignmentFacts__1415296640" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."AssignmentFacts" add constraint "FK_AssignmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1509508"."ModuleDims" ("Id") on delete cascade
/

alter table "S1509508"."Assignments" add constraint "FK_Assignments_Modul_762698328" foreign key ("ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId") references "S1509508"."ModuleRuns" ("AcademicYearId", "ModuleId", "LecturerId")
/

alter table "S1509508"."ModuleRuns" add constraint "FK_ModuleRuns_ModuleId" foreign key ("ModuleId") references "S1509508"."Modules" ("Id") on delete cascade
/

alter table "S1509508"."ModuleRuns" add constraint "FK_ModuleRuns_LecturerId" foreign key ("LecturerId") references "S1509508"."Lecturers" ("Id") on delete cascade
/

alter table "S1509508"."ModuleRuns" add constraint "FK_ModuleRuns_Id" foreign key ("Id") references "S1509508"."AcademicYears" ("Id") on delete cascade
/

alter table "S1509508"."Enrollments" add constraint "FK_Enrollments_Modul_888350027" foreign key ("ModuleRun_AcademicYearId", "ModuleRun_ModuleId", "ModuleRun_LecturerId") references "S1509508"."ModuleRuns" ("AcademicYearId", "ModuleId", "LecturerId")
/

alter table "S1509508"."Enrollments" add constraint "FK_Enrollments_StudentId" foreign key ("StudentId") references "S1509508"."Students" ("Id") on delete cascade
/

alter table "S1509508"."Students" add constraint "FK_Students_CountryId" foreign key ("CountryId") references "S1509508"."Countries" ("Id") on delete cascade
/

alter table "S1509508"."Students" add constraint "FK_Students_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade
/

alter table "S1509508"."Courses" add constraint "FK_Courses_CampusId" foreign key ("CampusId") references "S1509508"."Campus" ("Id") on delete cascade
/

alter table "S1509508"."Complaints" add constraint "FK_Complaints_AcademicYearId" foreign key ("AcademicYearId") references "S1509508"."AcademicYears" ("Id") on delete cascade
/

alter table "S1509508"."Complaints" add constraint "FK_Complaints_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade
/

alter table "S1509508"."CourseModules" add constraint "FK_CourseModules_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade
/

alter table "S1509508"."CourseModules" add constraint "FK_CourseModules_ModuleId" foreign key ("ModuleId") references "S1509508"."Modules" ("Id") on delete cascade
/

alter table "S1509508"."Results" add constraint "FK_Results_AssignmentId" foreign key ("AssignmentId") references "S1509508"."Assignments" ("Id") on delete cascade
/

alter table "S1509508"."Results" add constraint "FK_Results_StudentId" foreign key ("StudentId") references "S1509508"."Students" ("Id") on delete cascade
/

alter table "S1509508"."ComplaintFacts" add constraint "FK_ComplaintFacts_A_2016997436" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."ComplaintFacts" add constraint "FK_ComplaintFacts_CourseDimId" foreign key ("CourseDimId") references "S1509508"."CourseDims" ("Id") on delete cascade
/

alter table "S1509508"."EnrollmentFacts" add constraint "FK_EnrollmentFacts_A_230107921" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."EnrollmentFacts" add constraint "FK_EnrollmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1509508"."ModuleDims" ("Id") on delete cascade
/

alter table "S1509508"."GenderFacts" add constraint "FK_GenderFacts_Acad_1247701348" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."GenderFacts" add constraint "FK_GenderFacts_GenderDimId" foreign key ("GenderDimId") references "S1509508"."GenderDims" ("Id") on delete cascade
/

alter table "S1509508"."GraduationFacts" add constraint "FK_GraduationFacts__2010658651" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."GraduationFacts" add constraint "FK_GraduationFacts_CourseDimId" foreign key ("CourseDimId") references "S1509508"."CourseDims" ("Id") on delete cascade
/

alter table "S1509508"."Graduations" add constraint "FK_Graduations_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade
/

alter table "S1509508"."Graduations" add constraint "FK_Graduations_UserId" foreign key ("UserId") references "S1509508"."Users" ("Id") on delete cascade
/

alter table "S1509508"."Graduations" add constraint "FK_Graduations_YearId" foreign key ("YearId") references "S1509508"."AcademicYears" ("Id") on delete cascade
/

alter table "S1509508"."Permissions" add constraint "FK_Permissions_UserId" foreign key ("UserId") references "S1509508"."Users" ("Id") on delete cascade
/

alter table "S1509508"."LecturerFacts" add constraint "FK_LecturerFacts_Ac_1232305295" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."LecturerFacts" add constraint "FK_LecturerFacts_LecturerDimId" foreign key ("LecturerDimId") references "S1509508"."LecturerDims" ("Id") on delete cascade
/

alter table "S1509508"."ModuleFacts" add constraint "FK_ModuleFacts_Acade_145807659" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."ModuleFacts" add constraint "FK_ModuleFacts_CourseDimId" foreign key ("CourseDimId") references "S1509508"."CourseDims" ("Id") on delete cascade
/

alter table "S1509508"."ResultFacts" add constraint "FK_ResultFacts_Acad_1610824376" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."ResultFacts" add constraint "FK_ResultFacts_Clas_2054432834" foreign key ("ClassificationDimId") references "S1509508"."ClassificationDims" ("Id") on delete cascade
/

alter table "S1509508"."ResultFacts" add constraint "FK_ResultFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1509508"."ModuleDims" ("Id") on delete cascade
/

alter table "S1509508"."StudentFacts" add constraint "FK_StudentFacts_Aca_1878105390" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade
/

alter table "S1509508"."StudentFacts" add constraint "FK_StudentFacts_CountryDimId" foreign key ("CountryDimId") references "S1509508"."CountryDims" ("Id") on delete cascade
/

create table "S1509508"."__MigrationHistory"
(
  "MigrationId" nvarchar2(150) not null,
  "ContextKey" nvarchar2(300) not null,
  "Model" blob not null,
  "ProductVersion" nvarchar2(32) not null,
  constraint "PK___MigrationHistory" primary key ("MigrationId", "ContextKey")
) segment creation immediate
/

declare
  model_blob blob;
begin
  dbms_lob.createtemporary(model_blob, true);
  dbms_lob.append(model_blob, to_blob(cast('1F8B0800000000000400ED5DDB8EDC38927D5F60FF21918F839ECA2A37069836AA66E0F1A5614CBB6DB8DC3DBB4F0539932E0BA3541624A5C785C57ED93EEC27ED2FACEEE22522484A142565251AE8EE4A524146F0304806C9C3FFFB9FFFBDFEEBF77DB4FAC692343CC437EBAB8BCBF58AC5DBC32E8CEF6FD6C7ECCB1FFFBCFEEB5FFEFDDFAE5FEFF6DF57BF37F97E2CF2E55FC6E9CDFA6B963D3CDF6CD2ED57B60FD28B7DB84D0EE9E14B76B13DEC37C1EEB0797679F9D3E6EA6AC37211EB5CD66A75FDF11867E19E957FE47FBE3CC45BF6901D83E8DD61C7A2B4FE3D4FB92DA5AE7E0DF62C7D08B6EC66FD5B1C96D5CD1E5F0559F08F20615F0FC7945D147F5DE48232F63D4BD7AB175118E495BB65D197F52A88E343166479D59FFF96B2DB2C39C4F7B70FF90F41F4E9F181E5F9BE0451CA6A959E77D94DB5BB7C5668B7E93E6C446D8F6976D85B0ABCFAB136D746FEBC97D1D7AD397383BECE0D9F3D165A9746BD59BFD8063B967FFF9F2C485E85FBF54A2EF3F9CB2829F26B4C5F0A0E597A910B6171019320BA9084FFB0A244FCD0E22B8761F1CF0FAB97C7283B26EC2666C72C09A21F561F8E9FA370FB77F6F8E9F04F16DFC4C728E2D5CB15CCD3841FF29F3E24870796648F1FD9975AE9B7BBF56A237EB7913F6C3FE3BEA9ECF036CE7E7CB65EFD9A171E7C8E588B1ECE66B7D921613FB3982541C6761F822C63495CC860A5FD95D2A5B20A7BE94AE3255C6FBA76356EEDE14DFDFEA1D04F6DEA733B8FD4CEAA04DEECB75990648DB8DCD2EC53DE1507497C1DEF2CE59923314DC3FB387715D99B609B39763B82ECD9A051F2862A38C1AFF221F1183130BF1ECC409143D026D46588A0DF83E8C82C45FC1A7C0BEF4B6CD04AAE571F5954E64BBF860FD51C4082C49DF2C99BE4B0FF78881460CA39EF6E0FC7645B54FD6094FD5390DCB3CC5C97D6C2265A7099D1FAB7797435EF32427536EED75C9D5C76E956EC6C7AF3DCC796E2DF4D69F994379FD0AF57EF82EFBFB0F83EFB7AB3CE2788F91CFE4DF89DED9A9FEA2AE4F6CD1700F95759721CEEDD1DCF325AB9671C18E2E0539845CE81800D0DF9C2CE7A68D0F8C25C24E80BDBD4BB0E1429EF08C10CAD736BBC209CABF195A655FDC8D21C5E2958D12AED8EEF125D259544A5826A0EA87296FEB934AACB8ED98A9D4DBFE44762ABA99661E65FD8B6A83720DB6E5AE6664E36540AAFCD1039EE7ABFD0ABDDF57F7916447B09D3CABE8E934314E195EDD2EFB80ED8D5154A573C0198C9D653350D0D56B349ECE40B160592954A42796CEB587D4AB43A523F2511F1F643EA562DD9493C5659202016290402CBE441B3EF0E226EDD7B277736FEFD363B1633202BD75E4F4F6CDD3557D4704FED718AD4CBEBC8F0245D93693D6B0B82B5ACD3EE041FDA55124856BA359467D02CA9ADAFCB4E540B9D4D' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('0F9AFBCAE54D98A4D918CB5860FA13F82A2937C78E25E397F3F2708CB3E471A8CFCAC524A9FDEC12750475B5404750A7DDD5FD44F002729AE202940CB6037BA52956B13C09AB179F04554B48B7AD956E62D9C379CA0E9E72B0BD9C67DBC62E9D672DF4EC3C270CFF198CF0304AAD7AB68C4FB4EBF70567D9CD1D6333977986E6B4D094FD79B07F38A60E47AE521E353E343994D1A14A8080CDA5DA4EA95F1EF60F5110E25DAE4EBE6B10CF574B4C03462D2943BFC1B45A2F5036ABD7E350159564646C15F3D85654E7B64CC77DA46D1DF9AC1A584E7D5629F3ECB30C7D5665AE49F7D4DA4EE97AF0AAC59EB1608A85C6629FD8F7CCCB4AAECF12CCE59683D1D10BCD3024668506233E07E050C16CF6A326B1CAB31831F1EA4983D580496A1306773F55AD24CFA6C377081FB049A7F7116E3A52CFFDB6FE7107AB39123C0F81E751EEB663A4E99EB22323A4639B326226079BDC63EC70CFA6CFCC7D90F41D7FD0AF387A6115DEAC43006DBD6B4356D4748F13A922B00BDAAB2F751BC62E7B5323F5DC9F9ED46648DF2ED1E36082DC2DA8C30BBD3A467530CB6DB7A864CEA653D8EDB177076826DC64172B3144D2CF49BECE98DF692817670CE5BE819F4274B1C15F4B6FB328356B76A0906A35C90E6268CECFA5B76267D367E73E904D1B438B821CE35FC26DA98A7B34C8E2CFA8308DA909969B3EC6EAFE529A207A36B8E87727AD5AFECCE34E9A509745DD491310415D492333E2A1482717D25AF31AA8C0E5C52ADF66D154BBCBE72090EADECF376267D38FE7EEDF27DE392B4F908C01835AEE19074BC04177C2CDFDF02ECA9E0D1ECE77CEA71BDF454850033C9D933892EFE1CEB9541878E71CCBA3ABB9A33BE7D5996AE7EEBD153B9BDE3C77EF3ECEE1764B1CB8F7ED9DDCD920A19F5F6F113D03BF2ED465517EBD8303E5D3F15C8A5724B2DAFA72CE15D235E73282756ED3A9DA769986F9EF24D81DCBBA8ED07705D90BEFBFE7B88B93FE2B4082ECC3644EB567D0D9DD865EA4C2C0D80B9647577347D1974EAADB5DD24EEE6CFAB305CBC46F29441A6175304EDFD95D304B34159DE0FEE068FBA8C469BB0E55C0593B2591E8427DCFD915F6D6D5ACCA03D6AB48A26A55A6DBD6093DD8CB09964FF44A49549D86331E540619EA5D0A29B3F125735FE515C68ABD9C44FA10A4E9BF0EC96E849250C47F60C93E4C8B96868F2275E94A6794929483AE72FAA033AE9DB0E1F0EF64CDA613588C925DED0B9DEDFB8E8B714EAE438D571130AFE3E37EC0D8858E0F1690947D3106D94147459D47E238C1B301E8DCBDF4091C18B5069EFBF0012F7936D0EB173CE03AD10CC207526D161540E04141850FA87CE8F96427A103C113EB34103223B5E7F2D035E7333A201276DFA33BB90BEFCFE760A08BBEDCC181EAC9782EE4FA8D870020571018FC83D2A9DA3A0AFA' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('5587B6DDF7DB4EEEC2FB2D71B802EEE7F2A1E219F47767873240E516E5403A5C520E04CF85DC7A70E340D4E3EEB406C007A00E4A3E4A0B35B3DB132A5C51E0E914289DAAAFA35329F5B515F79E9013BC7057D81DA09C814F132BB3281FC42182724244368C15D0D53CA63D7FABA93D9F15AE789783AC3397CDAE171FF76090B58ADDBD4DDF44C17DF7609CBBC06B217F9CDE9C0BDDB1247A0CE37B1E9162DBBD63FBCF2CA9B5FE5B9086DBF5AA84F1CDFA52696821F38BDD3E8CDBCC57AA992B83F23FBE48D3C3362C0DA65C6F04312C16FF3ADEADECDEEAE982B1F2B353EF720B860FB9CD7293DFACFFA0A86A5C561BEBE7CA927BA258D8D55A7690EFE3572C62195BBDD816B6292E2DA6DBF212AAEC1AF36A89BFE43E9525456030885EE69D2B47431867AA030EE36DF81044562A49520C83A1452DDBF2E49457ECA13839146756ED685211937168D3162F595567C4EB0D875C2B4077F31243780113951140ACCE74B852B8B9D4CC81ABA8E11FB24A7B9954815E09FA8029FC8806861ECD8B1A32744AB679113A97171757043C354FF6403D40837E0B5B806CF9584D69EAFCAEA2FC830CE6DD947E0EA4979D2D0CA1B0F562D5C4A97BBB2AB664D023FA10A24680D15A1E025D7BF4724D984D3CB8244C7993A239BAF8491C9148A14B342FC4A72BA0AD3CB865DED560125E5E644DBE3AB73110ACB81F94A96D6004B19690792284814C94382E685A4A1E732D2FAB0DEC483A4B6415314714527A788123D54EB64B8619A0B376617AE0C8E7509D2152A6DBD6B9D739A150ACBB57FC89ED6138E862BCA7FEC65C915E941E2611AE5119200DFDA6ED288CD0BD2F017F68F5BD8DC860DB2C0085202D27BD40C4383AE58591A745074D72DBB773F40222651F0F48A42C611E10991A8A1CC7A4A6C921BAC9694108BD7D69102F700B3FD52CFEB0A71A6001C0931F1AD12C5635F196B18748BC3E53445B2083F85B06F78CB54C39E0424FC6610D4CBE1FA76DE4915047BE08DA2FF4DA0B7C84713C0090B08249E914B5AF0F14428CCE588393F4CE5D83774CE55E6048BE86ED6FCC258CE3018584114C4AE79F9D9F78038C8C06624F78F76A6654ECE2A27F70FDBD4DF6E4F6E85FB007A4A914DD182A08BEEE0E180DFBBC39D870926FA38DD5E9D1862AE00170689B18459809627CBFE86B266A1A8C2884EC0E7027B3B87B9E3E0E419C54757F7093DA6109F33A9AD4185F481A311C035B1CB627A0CCD89197748ACF48232F2B6283363472973339C387915B9B410BB873E51CBEEA952D2512B400C82A5A7807ABD256E6619C2901AA2198C53064CA360B85526CF16A4855BB247F6BA692070C9BB5E3923C2ECA356C082FF2D4B433102FF5D4B44E0DFF905DE8A9698200168390091B6C07229EC8D81CA60634B24BF2B37A753C0056DF6E4BF2AF20FFAF019C0032' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('60876055598415E97307A8A2825F682AED63523C4106EE0B8E34112F0A1D43565E0E4412C1B4054CCD287D17E5578D54F20160A3765C947FC538990DE145C60C9C8178A951039D1AFE21BBD0B881CA74AC470E71E897A7F9EE03CA051EF8452BEF1583CB3BEC2B339562E040694B215A551BD4A114BD9DE08A42756E88432AEE016F485B98948C92F87AF67224D6500A75871E6E5958432AEED7B72D156BE43922941ADF21D69679940851C02FE66C0F134D7A659064A1C570624649AB9EA9B45D7218B1D92E69D56CA29007B09AB4DF9256CC2811B111B0405662C7E085088D8132E60F5A4011DF8005DACBA40A2473B927A0123CC1188C4C4883E58D435BA81AB00D2FC9CBEAD5F100597DBB2DC9C38234D1067022639183C1BAD41824A5825F682E34F648D02563B031E14E960F28DB42D3807479497E54AF8E07B0EADB6D497E9464C93680154199ED10BC38D736EF5F5596EF19031855C92F84D1F633F2BB7A0E7FFF30D61FAFA399D31DC276A947EA2815FCC273A147E928E6720C374634E6CAED225B749A10A02F694A60A08F07C41AB4DD9226050875BD09A6201E7BA7A00518F0555ED6D94355D5C2334AD576325C68A12F5B8C82CDD7E57306F93759FE454BCEFF3E09B6112B7E65DFA157487E4B59FD62415A3FC02823AB907ACB32B8DFA5EBD5EBF61905CC112A60C545EAE4E98509ACDCA038893B5D23B01D212159DCC4C4B85E749D0CEB53B26560F5293908346278EE17550ECF9CA211D45216A952DA5BBD1A115557091924A3658FD6CB48524C42023CB7A20828C96961093501B0B60AF58D32B8162D23A791260D0F1EA64F432D6684161C2A5A014DE41D12D1D1AD688454B35448447399DCA871904ED826EAC5C88B30509CBA36366D78CCE548973D8D0080D5AE8B8C1AF5AA475C4E3BFA1BBB0A4C3FF9629546607BEE1C92C51DF7371283D589BF94A013249CE9048549276F8D05D2C2B4828A232D9088EAD490E6E30FFC3BF68A08FEF49CA10F405A4CD800351485195ADCB035726E98287E87C2C83F6182F8D886D960884912E6F492286E5687CD66D497BDB88FC0D90DBDA216160E862F29B51A03532D65926B2CBD599EF0D29589A6BCD4102D666F4D6EF2A6B5231229A37454E3656E6CA746CA38B9FC6C75B0BDE0B7610063193C22036C0362CFC828EA54935DC242F4AB31A0D95DD8077C2F06308FFE5D19411BF265194E19610A4F58877C4BC6C8D83D6CA33C2103D8857E6646D0017D6886AB3FB78C20AC813E10C349EA2AEDC20EDCB326B011B0774FE47A032F9F88EA572B205A79E0AD135E48BB0A72A039F8DC066802FDC31C921AE4D31C8251BA35196917F2310E6458726BA5669D4AD907BAAC832822DDD6196213E9768E1E73BDFB89F81401DA5B88170B00B8C36F16285AB44B656DFF815F2918C52C20373E3A02' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('531CFAC08089B0E82B4382C9E08B90DF9B5AB9BF69F8510BB50B46310B290250CCF6B308C00A3BE2682BD087E3E38CD9580B728CF71B6B3C8DB310A73560052DF535B49902925F1BA8A19505988498D4F5B00AC4B10C58454BC52C68429131739A709143C22C1487F258BD45A2FC2517349A9908420B3C6409E36BE6A1D2D10286D070D60A2AE0ACB59C166D2898B005CE533BDA524E6247C52D01F2A742B5971954FBD940E64C1D6B91425176523352CB209319CB273457D58749CC783DC78D306184915A132207B30905D5D3D92ECCA69ECA56467D47A6D250179261144BD419D21D82A3B0DE80860487E3020FE5CDD3DBD124B4A965D973633B7FA14D82C00DB09829DD9BA09B01E11BA79DB0994558CC80E26D5CA4810C62B4CD10A6314C2F956B6C989D547631459E2BDBD0745690952C08B044FDCC28B0784DE55D4ECA7A66A45723230DE352D2DBD16438D5322FB9B19DBF115525F5210DA50F9FE1DC3FA0694CCDE2257026F3CC00A620A96884BA6364345CCD85CD76C20C18FD0C27AADEF4778907CC0424430AD67C98097A20C1A309B0A53E49DC81D51B5BECF73081AFE53E491641C4842CC725237A09204AA4F7AB468412E38E48285781CE7E28AF01AE21C46C30DC6E10970120D5E9010253C4995EB007E266A668134E0C69A37113220DBCB34DDBCC64CE43DEEE1E66277FF31CE202311AB7B34495C18563259EA7B796C115E3715145DE60A56DA7B9F18AE989DF791D663FFC962B8F3AE0B8AF4B1B925116FD354B4C3732BAD2C356FEA22AD45D3E7C33CEB26F9A5CFE53C3E47A8B995CF71BB77B2277C93496C36E9DA1CA01F7CE86DA0BB869A61CCC7AB4B4527197AC10D1DE686AD3AE37B7DBAF6C1FD43F5C6FF22C5BF6901D832887338BD226E15DF0F010C6F769F765FDCBEAF621D816C1EF3FDEAE57DFF7519CDEACBF66D9C3F3CD262D45A71779D32687F4F025BBD81EF69B6077D83CBBBCFC697375B5D95732365B619354BE7FD596941D92E09E49A9855176EC4D98A4D9AB200B3E07C56AFDE56EAF6413EF6F89B66B4DDC94855CD152DBB03997DC7C58FC7F7DE23C0EBFE56BAF3CBDA8D73F82847D3D1C537651FC7551572355AE78492574867E93EB5E84774B3330BCFBA8127219B7DB200A92E66A1D77B1EFE5213AEE63FCA21FFE75B50AE4BF876E9555A8925490ADB851CC28215B6E1EEBC61BBBE50636DBFCDA0C93C0D7FA360B924C140724F7939D3B475C7299381F9C4907D047409A78CFB207D634024C5AA4BE7E8BB509723B17972DF025F0524922055CDEEF417464A2A4FAA7D920859B21BA07093A3536C007F1ED388EA8F8B7F87DF5CB6C9A8ABE7DE1AE430FEACCBE5AEB5398455273D53FD976F78FC718EEEE75C26CDA9F3CBEE7A6AB0257578CBB2AF8AD8917A75C781FFF0DB7A69DA426542ACBE27F3797' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('6606F58960451F961D8A2B8E6BC01E58D4C798ADB907B2799313EF66EBF0B41807419CFE1EDA8CC8C148833644BF1C675C2817DDEA50CEFD6CE104024854F7ABB9A4EA1C8A28A7F9CD5C4A1D69910DC4FD6C25AB7E284612853C1F3319A8BB7B7FEE51DDD08FD8A31AFDF289CE4D9BA31DA3B411708EC5AC89C00FA76E21B447969733951ED9FE3A9FB66E6E918ED0D8E03D5993C6463E1CA7B1ABD2D426E77F9F4F73751742C7E89D0DF1519F0E8A7E3B52B335057E2AD9D2C4814F481A731C1D674934A9DFC7AFA4BAF1FE359B55DF3100FB7CFC36B55F904E1A5B182FB0D03BAA30BFF17BA216EA2E5CBA6FA396EACDBE95F04F4F717D3751DB37570ADDB77CCDD067DFEED8873EC2325DB459192785148BF57952D2DD0ACBF30460C0A564CC3AC8C7512C8E356BEFB7CD437CFB441D3D70AE6D8426D31DF833693ABD8C91E6F142C1D22C4D4A9B4FB38A9776475C8AF5DC90D77C6FB26C71BD1F2F3C67A4CEC54F713F9E3B4B3DD66AAA676FC7BF7DAA8E9A3BF8385A6CBA7763A11F3FD1D6922FAEBB6F318927D9BED57402A670C14FF048147769DC3D48D0DBF206F820BE1DA753DB6D5B4EDA5C63756A8E68BC6F83CDA733B70092A50A09A7D599A5BBFD232044648FEF81128D80F3CCDB3352C645C9208498A303DA46B23F51575CD597A534BF4DB14936EB205BC56BE01E3B107983016AE0CFC699291465C5CA12A0FBD55CD287204DFF7548A4DA74BFCEA6B5794E10F76DCE3DE061DFF2D4C7E3F6F4AEE44261A90DA5B4D9B4A4C08B30DEEE5ABF493FF9F5798FCD3908C69A260A6FDFF487C17CA6881C30B153F2A7384DE4C933DCA3847BD6C81E23D4C7E745841774F0040EEED1C1BD55658F0EEAE353882C826FB0E35B83A7883E81DDC13DFCF807CEECF1477E3D917BE2DEF0056E542C1A2222F3063486294F7FF5BE33288A31BF1C5AF08D6057AEA0C7C354235A9FA4E5E4EBCFD45A9FE92CE492A73BAD2E1B7632A96B87E5ABDC8DC4BE0646DFDEEEBDBC20AB9543681716D05CBD4D7F3D46D1CDFA4B10A5AC6F53D9CAC39BC85612DE3032F78D752785DF9FEBBF29C94B31BF680920887A71EEDC4387F750EA8540C3FAF6396DE9F20AECB9F3EB3ABFC27F256769E707F52FEDDF2DFF55CD3D25906295CD58505C95CD97D63C583219559565BDCA5BE85BB8EB88A82EDE05712E7157E47BB1DDB2B4382818165EA1CD9AE708BFB034FB74F8278B6FD6575717CFD6AB175118A41579594DB8F57C7B4CB3C33E88E34356539B1930705DFD583070B1DD7E237F6ECFE3554849D35D04B078153E149E5F4A145C7F670A781B507F645F56D8E077BD913FBC0606D0EAE5E0F8B8FF5C6CA77F48D8364C4B435D5DE60E3AEF8B79EA65EDAA7F663942828CED3E0459C692B890C04A5DD6AB02A8C1E722770DD60D5974C5AE645838299B9FA11A' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('1BF96C610B0BABB20132ABAAA05D5EF741D24A022B6359E66D4FD03C99B5BEC11A0FF88A0822E8C103142936A7EC9E9EBF8D77ECFBCDFABF4A01CF576FFF4326997CBBFB61F53EC91DE8F3D5E5EABFDD0142D0D3BA92DCD7E354AF5EFE7A75370873D449FA9A6A13A52EFC5B906CBF06493E20BF0BBEFFC2E2FBECEBCD3A1F0F05CB66891C8FE8D1979F80653F556C52C34C8BF5D77ADA3CCE18814F9D7BFA0755D49D3A9DBE83E6C5D64EC5CA84DC547E3ACDAE46D18C5F5A4CA7DBB3DEBA593A6B853BCC7E6A60352F30CC4C2DF06CE61063F7F50128196BE01F04E0010EC4A872BD2AE5A632C61D030BC999F50C22D283760A3096A3073A5794B54DDB6FC79C1C9F07DBF3604B6AF664065B908BEF2467EFDC5935D733F8EEEC9A6BC9CDD51AD7723982406B78B7DF8EE3A1BB33E07D6A567EEA75540679FF4EB207798D2C405C7D67AB9A77F09624D0BE17D59FFAED45005BDF4936374F08E8AD2B81AC7AA7695E91B56F8471730E83936D6CC17273C2FF088A50F2994114BF356611EDD1A37AB66D3F93888F6580EF093823AF5E1EA6DD3B49BB2E602967DC6C106BDE18013D8A076FD1113D5131FB718FFB7C9C0AD6B481E3041B5D85312D27EAE7AD74F7B3749A3BEF240D2C53F3F95E10F93D8044DC713BA90348829E3DE7CA27760009A1CA3BC94EED3B4C08D2DA9D2D3BD4B214F5DCF998E6F998E6085E1261B33BC9BEEC6667CFD2B47E7B32412177523D59D0D3BA92DCD727D4930902BBF314FB3CC51E15727DE066715E14A3C0B2D899D063B1F73E8EBBFD1BB5528DE6D695AA3E3CE9F3223308CDA9EC7E273973EA28045D07FF3B4A414FB3B20F082B9F59BB5938A20F24D19EBEB967D9F365A5BC76369484EF24FBDC29EDB8E1BC7963CE4C4902BC939A9B4A9AF6BEEA7162F3538C8AEFBC1C3A2F8746801BC6ED3751E81686A79E7EEFA4603AF3902FD81CF6BD4995723ABD0A652C1CD98BA3DC8327D53F4445FB5E4C5936E4389628E58053013BB92D2418BE8E77AB8F87486DF7A6D60523D38592F62E1F2BC28728DCE635CAD55028DFDEC7AF58C432B67AB1ADA89B5E06E916780DB564F9426B2412BF08159292C4FAFC412926EF1C2C29D63241F4F210A759529CE6507B52186FC38720422C22E5375CA7154AB692E59457ECA108E7C719ACB24989263E62D39623595F67178185CC0A7618854AD7BC5D0EBE65B95F9F04C8103BCD065EF41CCD07B0608E581A552DD1A580AAF257B1152F2F2EAE948684D08120635454289C16481B19B05C9A5F6C40B2D3EC943D1068813E43264FEA734B6D4D59393DC01FA45FF5837E8E408217C7FF7C46BF0DFA7192DC33FA5720FAEB397A732900F7FBCDB56A1EA8ED6F5E66120D35025F83F6B751FA0978951C69D381C805791F90A238B280A93093A4EC0EBC22CC01A64A16F052FFE4052E' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('F5857509AFE54FE3800530C7385881AEE2635069AF9D4F8494FA60BFE0608D96C8E8FAD81B7C9A4BDA2282DA5F475F12FB811278151D294C4BE6E617532025450F07705208B2700E5EB1435C0AF737665513AFF90387BB7FAFD6A249583C7C309681792248C04EF5872E4A022C129F00842C9AD43784086A518F106A977FF3C58F659C6371C8B18B804C0C9B7ABD65B2449F74DC9A6481EE69B4B25C9F4F3950D555BDEB826138642C9A6C24D04C1503B56950BF51498A47C4077E9A98A4C938D592DCF06DD7FD78C263154CEF330E80EC46ABC963CA5D787B31D19E6930E43BDA6387A3C9F0531D95BCC3B632876C1F8F049F9A348AAF43F3D338C0B1DBE51D081B88120B298962B5F28B1E98487B4E331FDFA0F138E3B140CCD4B31D817B68C187F9440E2530E27C5A47F908D228A4C0B99CE41321875111C9EB7A1966DCAF4F00608895E6022DE2628F275089F4400B766412CF111C14382D5746513B2125CEC59749B05BCAA9E4A941E6F554720F784D7F2AB923485AB02FE3589EF8CAF03F9F8A0FC308AD90D2E6E2BF3898616C677273CAD0E27E3D695021F699059C086A335F401218B696ECB344AA30016252D2C9F82E821D0D297136FE4B84DD5216935383CCEB72B207BCA65F4F76959EFB71398E680EC6D1E20F1F60547A247826434E4703750730A075ED5626F22D56FDE005331CD1175F03FEE75130A31A641CC46044664869287399674F335BBC4CE5637CE1C5D2C3CC052F8B395F30157E7C9F30B0C4D1A4174978DEB905AFD704FA3CE818D669ADD570B640A4BCB9ACD404B8E16C956AC3CA30137E3F7988A1969A09BC481E494FD0EAA80C17ECC7383E467567E8B47C18463D899436170FC6C16C2971A6A940E535BE6409A7E9634B1D17E682FD1547E8A91EE13B2D7F85719722A5CDC55F7130D33DE6C8F92D25A7E0BFD4D493069BC66EB3809B016BAD7FC02DE520CC54C0F27A00C61250D31F7EE1686D173C42F2E4BCC031FBD31A23512662A4B8B90C923CD4D0C73B85697D930560027B0AD8C28C340F5851DCD4A320EA75C99A9C7F93E55FB0A4ADC68E956F94BC0AB2E07300EC1E175FDDB20CEE0DEBD5EB968C197361B7DBAF6C1FE4A9577FBAFCE94F977FCE6150913B4B3953A5D9A9C235251B166B50A6C47DAB962A65C0CB1532EA4BE666184AA15C1A5A5E9BC74649524123E54C152B6F6B228A95691AC5CAEBCEBAA2F8DBE94A597C225A187F395F575A7B2D4D29AA4D41CB6949237485B45C8E4A216D0A5A4895236446A5940743A042CA04AA8C3C83410935C7A05A429D80975067D0AAD01278015AB4698422751E536B35C42F88CD9A648DE51AC622B35E8476216DFFD197D0D1032865744968294D167D39CD654AA59426012DA3CA608A35D89572691AC419B95220F0A016A9E6C18B96F35A001F19B1A4747D0730' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('1BAFB89031D203349A36798C7D205A569BA8F1848F46A5C9174D888144635131A3BE64EEC4BA5228978696D7E6312D0A51904FD41466A8987476542D51CA80972A64B429992CD5A8447D69D5C927A59CEA67B48422592F9B3F03A794C027A2E57499CC0703188C42AA76483002A4B8658D96A881079FCD744C454AE4133563AB59697CEC0E19FB34A575998C27A7487142AA6E920A17C8AD3BB1E59312235B711F81EB293AAA46C7D55A0B0069CA829B9303AEF82A3152921C07114D606F1E6E59A7350C1A988543D79C16DCAF333103FCB20960038327500003704B4DCE00E5AF4606409477A038F8A605A0B7FEED0B676AAB4BE6F263FEE7C16A2B8F19002AD30F1E40B14EA1BEED6F84AAD27ABDFCAEFDCD85921CFB3EAC2146CF2FAA27AC942BEDC025B06C146E05DFD82401DE6AEBA31A48170FEAA8279647BD38EAC2358A4BEBFE5AF7F65787EA3716A51487AF9FF46929EF6AAA54DC288C09C66E27CAAA0116EEDB26C1D140247147A3E310C5310DF863C019CF49693EAC8A6A8C514D3A50D772D0EAEF9135A30E4EE1EB00C8E30E3910A32CA0A49678B66F95BD4F24200A5440612D53AA507139EE5956BBFB7152084B949DE41479F491767C7555864940630D0DE5B049BDF0B518A92EBF6C7E72A56ADBB3503D117A40073D764CF568FA3E6A02355118008CA28B732C47AB5F8C664E6B14F4F0327CBC5B19A9E663020D291AB9229E081FF0AE8034C48D631E324C6446F4E52C4CE4D30C04D51460085362AA51D0A16EA79422F89F5D9A83DB0C220D815203C1E4494ACD67A1364DE00319C082F2671C3480DB5D9569A424D7E621871333521A67E3C934662042171AEE1407EB3D75BB5152D781AA328F07A02849F5215498DFB12CAB5AFD40A8A8EE4396DFF13FBB6C4D4C45929D62A08A3E5A51664BA0551C7D6DE74365F2623FB18C9FC88B433BD2426CC091EB422FA0EB4C425CC1C6AEAB035ACCC50CC4656934EC311132D47303DC0CDABD39C8315D7FF9D7D978EE436DE20A2A1A22990805EA790E2E84E2DE1CC02942D220DA2B82F4E54A1E1D6AEA7CCC422E8EF517FF9C2D8C7DA84D5D3FC3E3FE13750FE000121F991CC124FC4950DA1AF85D21E44A957AD2C0AFFAC59DAB42447B9FA74DBBDE54C7B7EA1FF23FB34312DC17DB852C4ACB5FAF371FF32A877B56FDF58A15C1EF56C4752E3366E595AF4E6893E76DFCE5D05C66926AD46469929B718B65C12EC8821749167EC995CC93B72C771FF1FD7AF57B101D8B18D2FE33DBBD8DDF1FB3876396ABCCF69F23E1E446711D8A2AFF7AA3D4F9FAFD43F157EA4285BC9A61AE027B1FFFED1846BBB6DE6F82485EFE61228A7B563FB3FCF7AA2DB3FCBFECFEB195F4EB213614549BAFBD1EF6891591D88CA5EFE3DBE01BEB53B77CF9F30BBB0FB68FF9EFDFC25DB116C284E81B4234FBF5' as long raw)));
  dbms_lob.append(model_blob, to_blob(cast('AB30B84F827D5ACBE8BECFFFCC31BCDB7FFFCBFF031A98E8E25C290200' as long raw)));
  insert into "S1509508"."__MigrationHistory"("MigrationId", "ContextKey", "Model", "ProductVersion")
  values ('201905081804039_InitialCreate', 'UniversityDataWarehouse.Data.Migrations.Configuration', model_blob, '6.2.0-61023');
end;
