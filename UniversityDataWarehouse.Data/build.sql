---- OP-DB ----

-- TABLES
create table "S1509508"."AcademicYears"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  "AcademicYearStart" date not null,
  "AcademicYearEnd" date not null,
  constraint "PK_AcademicYears" primary key ("Id")
);

create table "S1509508"."Assignments"
(
  "Id" number(10, 0) not null,
  "Title" nvarchar2(2000) null,
  "ModuleRunId" number(10, 0) not null,
  constraint "PK_Assignments" primary key ("Id")
);

create table "S1509508"."ModuleRuns"
(
  "Id" number(10, 0) not null,
  "AcademicYearId" number(10, 0) not null,
  "ModuleId" number(10, 0) not null,
  "LecturerId" number(10, 0) not null,
  constraint "PK_ModuleRuns" primary key ("Id")
);

create table "S1509508"."Enrollments"
(
  "StudentId" number(10, 0) not null,
  "ModuleRunId" number(10, 0) not null,
  constraint "PK_Enrollments" primary key ("StudentId", "ModuleRunId")
);

create table "S1509508"."Students"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  "Gender" nvarchar2(2000) null,
  "CountryId" number(10, 0) not null,
  "CourseId" number(10, 0) not null,
  constraint "PK_Students" primary key ("Id")
);

create table "S1509508"."Countries"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Countries" primary key ("Id")
);

create table "S1509508"."Courses"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  "CampusId" number(10, 0) not null,
  constraint "PK_Courses" primary key ("Id")
);

create table "S1509508"."Campus"
(
  "Id" number(10, 0) not null,
  "CampusName" nvarchar2(2000) null,
  constraint "PK_Campus" primary key ("Id")
);

create table "S1509508"."Complaints"
(
  "Id" number(10, 0) not null,
  "ComplaintText" nvarchar2(2000) null,
  "CourseId" number(10, 0) not null,
  "AcademicYearId" number(10, 0) not null,
  constraint "PK_Complaints" primary key ("Id")
);

create table "S1509508"."CourseModules"
(
  "CourseId" number(10, 0) not null,
  "ModuleId" number(10, 0) not null,
  constraint "PK_CourseModules" primary key ("CourseId", "ModuleId")
);

create table "S1509508"."Modules"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_Modules" primary key ("Id")
);

create table "S1509508"."Lecturers"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  constraint "PK_Lecturers" primary key ("Id")
);

create table "S1509508"."Results"
(
  "StudentId" number(10, 0) not null,
  "AssignmentId" number(10, 0) not null,
  "Grade" number(10, 0) not null,
  "Id" number(10, 0) not null,
  constraint "PK_Results" primary key ("StudentId", "AssignmentId")
);

create table "S1509508"."Graduations"
(
  "Id" number(10, 0) not null,
  "YearId" number(10, 0) not null,
  "StudentId" number(10, 0) not null,
  "CourseId" number(10, 0) not null,
  constraint "PK_Graduations" primary key ("Id")
);

create table "S1509508"."Permissions"
(
  "UserId" number(10, 0) not null,
  "PermissionType" number(10, 0) not null,
  constraint "PK_Permissions" primary key ("UserId", "PermissionType")
);

create table "S1509508"."Users"
(
  "Id" number(10, 0) not null,
  "Username" nvarchar2(2000) null,
  "Password" nvarchar2(2000) null,
  constraint "PK_Users" primary key ("Id")
);

-- INDEXES

create index "S1509508"."IX_Assignments_ModuleRunId" on "S1509508"."Assignments" ("ModuleRunId");
create index "S1509508"."IX_ModuleRuns_AcademicYearId" on "S1509508"."ModuleRuns" ("AcademicYearId");
create index "S1509508"."IX_ModuleRuns_ModuleId" on "S1509508"."ModuleRuns" ("ModuleId");
create index "S1509508"."IX_ModuleRuns_LecturerId" on "S1509508"."ModuleRuns" ("LecturerId");
create index "S1509508"."IX_Enrollments_StudentId" on "S1509508"."Enrollments" ("StudentId");
create index "S1509508"."IX_Enrollments_ModuleRunId" on "S1509508"."Enrollments" ("ModuleRunId");
create index "S1509508"."IX_Students_CountryId" on "S1509508"."Students" ("CountryId");
create index "S1509508"."IX_Students_CourseId" on "S1509508"."Students" ("CourseId");
create index "S1509508"."IX_Courses_CampusId" on "S1509508"."Courses" ("CampusId");
create index "S1509508"."IX_Complaints_CourseId" on "S1509508"."Complaints" ("CourseId");
create index "S1509508"."IX_Complaints_AcademicYearId" on "S1509508"."Complaints" ("AcademicYearId");
create index "S1509508"."IX_CourseModules_CourseId" on "S1509508"."CourseModules" ("CourseId");
create index "S1509508"."IX_CourseModules_ModuleId" on "S1509508"."CourseModules" ("ModuleId");
create index "S1509508"."IX_Results_StudentId" on "S1509508"."Results" ("StudentId");
create index "S1509508"."IX_Results_AssignmentId" on "S1509508"."Results" ("AssignmentId");
create index "S1509508"."IX_Graduations_YearId" on "S1509508"."Graduations" ("YearId");
create index "S1509508"."IX_Graduations_StudentId" on "S1509508"."Graduations" ("StudentId");
create index "S1509508"."IX_Graduations_CourseId" on "S1509508"."Graduations" ("CourseId");
create index "S1509508"."IX_Permissions_UserId" on "S1509508"."Permissions" ("UserId");

-- SEQUENCES

create sequence "S1509508"."SQ_AcademicYears";
create sequence "S1509508"."SQ_Assignments";
create sequence "S1509508"."SQ_ModuleRuns";
create sequence "S1509508"."SQ_Students";
create sequence "S1509508"."SQ_Countries";
create sequence "S1509508"."SQ_Courses";
create sequence "S1509508"."SQ_Campus";
create sequence "S1509508"."SQ_Complaints";
create sequence "S1509508"."SQ_Modules";
create sequence "S1509508"."SQ_Lecturers";
create sequence "S1509508"."SQ_Graduations";
create sequence "S1509508"."SQ_Users";


-- TRIGGERS

create or replace trigger "S1509508"."TR_AcademicYears"
  before insert on "S1509508"."AcademicYears"
  for each row
begin
  select "S1509508"."SQ_AcademicYears".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Assignments"
  before insert on "S1509508"."Assignments"
  for each row
begin
  select "S1509508"."SQ_Assignments".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_ModuleRuns"
  before insert on "S1509508"."ModuleRuns"
  for each row
begin
  select "S1509508"."SQ_ModuleRuns".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Students"
  before insert on "S1509508"."Students"
  for each row
begin
  select "S1509508"."SQ_Students".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Countries"
  before insert on "S1509508"."Countries"
  for each row
begin
  select "S1509508"."SQ_Countries".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Courses"
  before insert on "S1509508"."Courses"
  for each row
begin
  select "S1509508"."SQ_Courses".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Campus"
  before insert on "S1509508"."Campus"
  for each row
begin
  select "S1509508"."SQ_Campus".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Complaints"
  before insert on "S1509508"."Complaints"
  for each row
begin
  select "S1509508"."SQ_Complaints".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Modules"
  before insert on "S1509508"."Modules"
  for each row
begin
  select "S1509508"."SQ_Modules".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Lecturers"
  before insert on "S1509508"."Lecturers"
  for each row
begin
  select "S1509508"."SQ_Lecturers".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Graduations"
  before insert on "S1509508"."Graduations"
  for each row
begin
  select "S1509508"."SQ_Graduations".nextval into :new."Id" from dual;
end;

create or replace trigger "S1509508"."TR_Users"
  before insert on "S1509508"."Users"
  for each row
begin
  select "S1509508"."SQ_Users".nextval into :new."Id" from dual;
end;

-- FOREIGN KEYS
alter table "S1509508"."Assignments" add constraint "FK_Assignments_ModuleRunId" foreign key ("ModuleRunId") references "S1509508"."ModuleRuns" ("Id") on delete cascade;
alter table "S1509508"."ModuleRuns" add constraint "FK_ModuleRuns_ModuleId" foreign key ("ModuleId") references "S1509508"."Modules" ("Id") on delete cascade;
alter table "S1509508"."ModuleRuns" add constraint "FK_ModuleRuns_LecturerId" foreign key ("LecturerId") references "S1509508"."Lecturers" ("Id") on delete cascade;
alter table "S1509508"."ModuleRuns" add constraint "FK_ModuleRuns_AcademicYearId" foreign key ("AcademicYearId") references "S1509508"."AcademicYears" ("Id") on delete cascade;
alter table "S1509508"."Enrollments" add constraint "FK_Enrollments_ModuleRunId" foreign key ("ModuleRunId") references "S1509508"."ModuleRuns" ("Id") on delete cascade;
alter table "S1509508"."Enrollments" add constraint "FK_Enrollments_StudentId" foreign key ("StudentId") references "S1509508"."Students" ("Id") on delete cascade;
alter table "S1509508"."Students" add constraint "FK_Students_CountryId" foreign key ("CountryId") references "S1509508"."Countries" ("Id") on delete cascade;
alter table "S1509508"."Students" add constraint "FK_Students_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade;
alter table "S1509508"."Courses" add constraint "FK_Courses_CampusId" foreign key ("CampusId") references "S1509508"."Campus" ("Id") on delete cascade;
alter table "S1509508"."Complaints" add constraint "FK_Complaints_AcademicYearId" foreign key ("AcademicYearId") references "S1509508"."AcademicYears" ("Id") on delete cascade;
alter table "S1509508"."Complaints" add constraint "FK_Complaints_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade;
alter table "S1509508"."CourseModules" add constraint "FK_CourseModules_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade;
alter table "S1509508"."CourseModules" add constraint "FK_CourseModules_ModuleId" foreign key ("ModuleId") references "S1509508"."Modules" ("Id") on delete cascade;
alter table "S1509508"."Results" add constraint "FK_Results_AssignmentId" foreign key ("AssignmentId") references "S1509508"."Assignments" ("Id") on delete cascade;
alter table "S1509508"."Results" add constraint "FK_Results_StudentId" foreign key ("StudentId") references "S1509508"."Students" ("Id") on delete cascade;
alter table "S1509508"."Graduations" add constraint "FK_Graduations_CourseId" foreign key ("CourseId") references "S1509508"."Courses" ("Id") on delete cascade;
alter table "S1509508"."Graduations" add constraint "FK_Graduations_StudentId" foreign key ("StudentId") references "S1509508"."Students" ("Id") on delete cascade;
alter table "S1509508"."Graduations" add constraint "FK_Graduations_YearId" foreign key ("YearId") references "S1509508"."AcademicYears" ("Id") on delete cascade;
alter table "S1509508"."Permissions" add constraint "FK_Permissions_UserId" foreign key ("UserId") references "S1509508"."Users" ("Id") on delete cascade;



---- DIM-DB (FACTS) ----

-- TABLES

create table "S1509508"."AssignmentFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "ModuleDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_AssignmentFacts" primary key ("AcademicYearDimId", "ModuleDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."ComplaintFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CourseDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_ComplaintFacts" primary key ("AcademicYearDimId", "CourseDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."CourseFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CampusDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_CourseFacts" primary key ("AcademicYearDimId", "CampusDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."EnrollmentFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "ModuleDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_EnrollmentFacts" primary key ("AcademicYearDimId", "ModuleDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."GenderFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "GenderDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_GenderFacts" primary key ("AcademicYearDimId", "GenderDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."GraduationFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CourseDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_GraduationFacts" primary key ("AcademicYearDimId", "CourseDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."LecturerFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "LecturerDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_LecturerFacts" primary key ("AcademicYearDimId", "LecturerDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."ModuleFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CourseDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_ModuleFacts" primary key ("AcademicYearDimId", "CourseDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."ResultFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "ModuleDimId" number(10, 0) not null,
  "ClassificationDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_ResultFacts" primary key ("AcademicYearDimId", "ModuleDimId", "ClassificationDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

create table "S1509508"."StudentFacts"
(
  "AcademicYearDimId" number(10, 0) not null,
  "CountryDimId" number(10, 0) not null,
  "Value" number(10, 0) not null,
  constraint "PK_StudentFacts" primary key ("AcademicYearDimId", "CountryDimId")
)
  PARTITION BY RANGE ("AcademicYearDimId") INTERVAL (1)
(
  PARTITION P0 VALUES LESS THAN (1)
);

-- INDEXES

create bitmap index "S1509508"."IX_AssignmentFacts__1448872138" on "S1509508"."AssignmentFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_AssignmentFacts_ModuleDimId" on "S1509508"."AssignmentFacts" ("ModuleDimId") LOCAL;
create bitmap index "S1509508"."IX_ComplaintFacts_A_1386423654" on "S1509508"."ComplaintFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_ComplaintFacts_CourseDimId" on "S1509508"."ComplaintFacts" ("CourseDimId") LOCAL;
create bitmap index "S1509508"."IX_CourseFacts_Acad_1029085906" on "S1509508"."CourseFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_CourseFacts_CampusDimId" on "S1509508"."CourseFacts" ("CampusDimId") LOCAL;
create bitmap index "S1509508"."IX_EnrollmentFacts_A_177810579" on "S1509508"."EnrollmentFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_EnrollmentFacts_ModuleDimId" on "S1509508"."EnrollmentFacts" ("ModuleDimId") LOCAL;
create bitmap index "S1509508"."IX_GenderFacts_Acad_1333264266" on "S1509508"."GenderFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_GenderFacts_GenderDimId" on "S1509508"."GenderFacts" ("GenderDimId") LOCAL;
create bitmap index "S1509508"."IX_GraduationFacts_A_465991385" on "S1509508"."GraduationFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_GraduationFacts_CourseDimId" on "S1509508"."GraduationFacts" ("CourseDimId") LOCAL;
create bitmap index "S1509508"."IX_LecturerFacts_Aca_925118121" on "S1509508"."LecturerFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_LecturerFacts_LecturerDimId" on "S1509508"."LecturerFacts" ("LecturerDimId") LOCAL;
create bitmap index "S1509508"."IX_ModuleFacts_Acad_2060256043" on "S1509508"."ModuleFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_ModuleFacts_CourseDimId" on "S1509508"."ModuleFacts" ("CourseDimId") LOCAL;
create bitmap index "S1509508"."IX_ResultFacts_Acad_1508787010" on "S1509508"."ResultFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_ResultFacts_ModuleDimId" on "S1509508"."ResultFacts" ("ModuleDimId") LOCAL;
create bitmap index "S1509508"."IX_ResultFacts_Clas_1227287608" on "S1509508"."ResultFacts" ("ClassificationDimId") LOCAL;
create bitmap index "S1509508"."IX_StudentFacts_Aca_1313936632" on "S1509508"."StudentFacts" ("AcademicYearDimId") LOCAL;
create bitmap index "S1509508"."IX_StudentFacts_CountryDimId" on "S1509508"."StudentFacts" ("CountryDimId") LOCAL;


---- DIM_DB (DIMS) ----

-- TABLES

create table "S1509508"."AcademicYearDims"
(
  "Id" number(10, 0) not null,
  "Year" number(10, 0) not null,
  constraint "PK_AcademicYearDims" primary key ("Id")
);

create table "S1509508"."ModuleDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_ModuleDims" primary key ("Id")
);

create table "S1509508"."CampusDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CampusDims" primary key ("Id")
);

create table "S1509508"."ClassificationDims"
(
  "Id" number(10, 0) not null,
  "Classification" nvarchar2(2000) null,
  constraint "PK_ClassificationDims" primary key ("Id")
);

create table "S1509508"."CourseDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CourseDims" primary key ("Id")
);

create table "S1509508"."CountryDims"
(
  "Id" number(10, 0) not null,
  "Name" nvarchar2(2000) null,
  constraint "PK_CountryDims" primary key ("Id")
);

create table "S1509508"."GenderDims"
(
  "Id" number(10, 0) not null,
  "Gender" nvarchar2(2000) null,
  constraint "PK_GenderDims" primary key ("Id")
);

create table "S1509508"."LecturerDims"
(
  "Id" number(10, 0) not null,
  "FirstName" nvarchar2(2000) null,
  "LastName" nvarchar2(2000) null,
  constraint "PK_LecturerDims" primary key ("Id")
);

---- FACT/DIM FOREIGN KEYS ----

alter table "S1509508"."AssignmentFacts" add constraint "FK_AssignmentFacts__1415296640" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."AssignmentFacts" add constraint "FK_AssignmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1509508"."ModuleDims" ("Id") on delete cascade;
alter table "S1509508"."ComplaintFacts" add constraint "FK_ComplaintFacts_A_2016997436" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."ComplaintFacts" add constraint "FK_ComplaintFacts_CourseDimId" foreign key ("CourseDimId") references "S1509508"."CourseDims" ("Id") on delete cascade;
alter table "S1509508"."CourseFacts" add constraint "FK_CourseFacts_Acad_1490274820" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."CourseFacts" add constraint "FK_CourseFacts_CampusDimId" foreign key ("CampusDimId") references "S1509508"."CampusDims" ("Id") on delete cascade;
alter table "S1509508"."EnrollmentFacts" add constraint "FK_EnrollmentFacts_A_230107921" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."EnrollmentFacts" add constraint "FK_EnrollmentFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1509508"."ModuleDims" ("Id") on delete cascade;
alter table "S1509508"."GenderFacts" add constraint "FK_GenderFacts_Acad_1247701348" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."GenderFacts" add constraint "FK_GenderFacts_GenderDimId" foreign key ("GenderDimId") references "S1509508"."GenderDims" ("Id") on delete cascade;
alter table "S1509508"."GraduationFacts" add constraint "FK_GraduationFacts__2010658651" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."GraduationFacts" add constraint "FK_GraduationFacts_CourseDimId" foreign key ("CourseDimId") references "S1509508"."CourseDims" ("Id") on delete cascade;
alter table "S1509508"."LecturerFacts" add constraint "FK_LecturerFacts_Ac_1232305295" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."LecturerFacts" add constraint "FK_LecturerFacts_LecturerDimId" foreign key ("LecturerDimId") references "S1509508"."LecturerDims" ("Id") on delete cascade;
alter table "S1509508"."ModuleFacts" add constraint "FK_ModuleFacts_Acade_145807659" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."ModuleFacts" add constraint "FK_ModuleFacts_CourseDimId" foreign key ("CourseDimId") references "S1509508"."CourseDims" ("Id") on delete cascade;
alter table "S1509508"."ResultFacts" add constraint "FK_ResultFacts_Acad_1610824376" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."ResultFacts" add constraint "FK_ResultFacts_Clas_2054432834" foreign key ("ClassificationDimId") references "S1509508"."ClassificationDims" ("Id") on delete cascade;
alter table "S1509508"."ResultFacts" add constraint "FK_ResultFacts_ModuleDimId" foreign key ("ModuleDimId") references "S1509508"."ModuleDims" ("Id") on delete cascade;
alter table "S1509508"."StudentFacts" add constraint "FK_StudentFacts_Aca_1878105390" foreign key ("AcademicYearDimId") references "S1509508"."AcademicYearDims" ("Id") on delete cascade;
alter table "S1509508"."StudentFacts" add constraint "FK_StudentFacts_CountryDimId" foreign key ("CountryDimId") references "S1509508"."CountryDims" ("Id") on delete cascade;