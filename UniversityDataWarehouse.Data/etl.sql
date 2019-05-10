--------------------------------------------------------
---- OPERATIONAL --> DIMENSIONAL EXTRACTIONS [DIMS] ----
--------------------------------------------------------

-- ACADEMIC YEAR DIM EXTRACTION
CREATE OR REPLACE PROCEDURE S1509508.USP_AcademicYearDims AS
BEGIN
  INSERT INTO "AcademicYearDims"
  SELECT "Id",
         "Year"
  FROM
    "AcademicYears"
  WHERE NOT EXISTS(
      SELECT *
      FROM "AcademicYearDims"
      WHERE "AcademicYearDims"."Id" = "AcademicYears"."Id"
    );
END;

-- CAMPUS DIM EXTRACTION
CREATE OR REPLACE PROCEDURE S1509508.USP_CampusDims AS
BEGIN
  INSERT INTO "CampusDims"
  SELECT "Id",
         "CampusName"
  FROM "Campus"
  WHERE NOT EXISTS(
      SELECT *
      FROM "CampusDims"
      WHERE "CampusDims"."Id" = "Campus"."Id"
    );
END;

-- COUNTRY DIM EXTRACTION
CREATE OR REPLACE PROCEDURE S1509508.USP_CountryDims AS
BEGIN
  INSERT INTO "CountryDims"
  SELECT "Id",
         "Name"
  FROM "Countries"
  WHERE NOT EXISTS(
      SELECT *
      FROM "CountryDims"
      WHERE "CountryDims"."Id" = "Countries"."Id"
    );
END;

-- COURSE DIM EXTRACTION
CREATE OR REPLACE PROCEDURE S1509508.USP_CourseDims AS
BEGIN
  INSERT INTO "CourseDims"
  SELECT "Id",
         "Name"
  FROM "Courses"
  WHERE NOT EXISTS(
      SELECT *
      FROM "CourseDims"
      WHERE "CourseDims"."Id" = "Courses"."Id"
    );
END;

-- LECTURER DIM EXTRACTION
CREATE OR REPLACE PROCEDURE S1509508.USP_LecturerDims AS
BEGIN
  INSERT INTO "LecturerDims"
  SELECT "Id",
         "FirstName",
         "LastName"
  FROM "Lecturers"
  WHERE NOT EXISTS(
      SELECT *
      FROM "LecturerDims"
      WHERE "LecturerDims"."Id" = "Lecturers"."Id"
    );
END;

-- MODULE DIM EXTRACTION
CREATE OR REPLACE PROCEDURE S1509508.USP_ModuleDims AS
BEGIN
  INSERT INTO "ModuleDims"
  SELECT "Id",
         "Name"
  FROM "Modules"
  WHERE NOT EXISTS(
      SELECT *
      FROM "ModuleDims"
      WHERE "ModuleDims"."Id" = "Modules"."Id"
    );
END;

---------------------------------
---- CLASSIFICATION HANDLING ----
---------------------------------

-- CONVERT CLASSIFICATION STRING --> CLASSIFICATION DIM ID
CREATE OR REPLACE FUNCTION S1509508.UFN_ClassificationDimsGetId(ClassificationString in NVARCHAR2) RETURN NUMBER AS id NUMBER;
  BEGIN
    SELECT "Id"
      INTO id
    FROM "ClassificationDims"
      WHERE "Classification" = ClassificationString;
      
    RETURN id;
  END;
  
-- CONVERT RESULT GRADE VALUE --> CLASSIFICATION DIM STRING
CREATE OR REPLACE FUNCTION S1509508.UFN_MapGradeToClassification(grade in NUMBER) RETURN NVARCHAR2 AS
  BEGIN
    IF grade < 40 THEN
      RETURN 'U';
    ELSIF grade >= 40 AND grade < 50 THEN
      RETURN '3';
    ELSIF grade >= 50 AND grade < 60 THEN
      RETURN '2.2';
    ELSIF grade >= 60 AND grade < 70 THEN
      RETURN '2.1';
    ELSIF grade >= 70 THEN
      RETURN '1';
    END IF;
  END;

-- POPULATE CLASSIFICATION DIMS
CREATE OR REPLACE PROCEDURE S1509508.USP_ClassificationDimsEtl AS
  noOfClassifications NUMBER;
BEGIN
  SELECT COUNT("Id")
         INTO noOfClassifications
  FROM "ClassificationDims";

  IF noOfClassifications = 0 THEN
    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('U');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('3');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('2.2');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('2.1');

    INSERT INTO "ClassificationDims"
    ("Classification")
    VALUES
    ('1');
  END IF;
END;
  
-------------------------
---- GENDER HANDLING ----
-------------------------

-- CONVERT GENDER STRING --> GENDER DIM ID
CREATE OR REPLACE FUNCTION S1509508.UFN_GenderDimsGetId(GenderString in NVARCHAR2) RETURN NUMBER AS id NUMBER;
  BEGIN
    SELECT "Id"
      INTO id
    FROM "GenderDims"
      WHERE "Gender" = GenderString;
      
    RETURN id;
  END;
  
-- POPULATE GENDER DIMS
CREATE OR REPLACE PROCEDURE S1509508.USP_GenderDimsEtl AS
  noOfGenders NUMBER;
BEGIN
  SELECT COUNT("Id")
    INTO noOfGenders
  FROM "GenderDims";
    
  IF noOfGenders = 0 THEN
    INSERT INTO "GenderDims"
    ("Gender")
    VALUES
    ('Male');

    INSERT INTO "GenderDims"
    ("Gender")
    VALUES
    ('Female');
  
    INSERT INTO "GenderDims"
    ("Gender")
    VALUES
    ('Prefer not to say');
  END IF;
end;
  
--------------------------------
---- ACADEMIC YEAR HANDLING ----
--------------------------------

-- CONVERT CURRENT DATETIME --> CURRENT ACADEMIC YEAR
CREATE OR REPLACE FUNCTION S1509508.UFN_GetCurrentAcademicYear RETURN NUMBER AS id NUMBER;
  BEGIN
    SELECT "Id"
      INTO id
    FROM "AcademicYears"
    WHERE
      "AcademicYearStart" <= CURRENT_DATE
      AND "AcademicYearEnd" > CURRENT_DATE;
      
    RETURN id;
  end;

---------------------------------------------------------
---- OPERATIONAL --> DIMENSIONAL EXTRACTIONS [FACTS] ----
---------------------------------------------------------

-- GENERATE ASSIGNMENT FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_AssignmentFactEtl AS
  BEGIN
    INSERT INTO "AssignmentFacts"
    SELECT  RUNS."AcademicYearId",
           "ModuleId",
           COUNT("Assignments"."Id")
    FROM "Assignments"
      INNER JOIN "ModuleRuns" RUNS
        ON "Assignments"."ModuleRunId" = RUNS."Id"
    WHERE NOT EXISTS(
      SELECT *
      FROM "AssignmentFacts"
      WHERE "ModuleDimId" = "ModuleId"
      AND "AcademicYearDimId" = RUNS."Id"
      )
    GROUP BY RUNS."AcademicYearId",
             "ModuleId"
    ORDER BY RUNS."AcademicYearId",
             "ModuleId";
  END;

-- GENERATE COMPLAINT FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_ComplaintFactEtl AS
BEGIN
  INSERT INTO "ComplaintFacts"
  SELECT "AcademicYearId",
         "CourseId",
         COUNT("Complaints"."Id")
  FROM "Complaints"
  WHERE NOT EXISTS(
      SELECT *
      FROM "ComplaintFacts"
      WHERE "CourseDimId" = "CourseId"
        AND "AcademicYearDimId" = "AcademicYearId"
    )
  GROUP BY "AcademicYearId",
           "CourseId"
  ORDER BY "AcademicYearId",
           "CourseId";
END;

-- GENERATE COURSE FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_CourseFactEtl AS
BEGIN
  INSERT INTO "CourseFacts"
  SELECT UFN_GetCurrentAcademicYear(),
         "CampusId",
         COUNT("Courses"."Id")
  FROM "Courses"
  WHERE NOT EXISTS(
      SELECT *
      FROM "CourseFacts"
      WHERE "CampusDimId" = "CampusId"
        AND "AcademicYearDimId" = UFN_GetCurrentAcademicYear()
    )
  GROUP BY UFN_GetCurrentAcademicYear(),
           "CampusId"
  ORDER BY UFN_GetCurrentAcademicYear(),
           "CampusId";
END;

-- GENERATE ENROLLMENT FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_EnrollmentFactEtl AS
BEGIN
  INSERT INTO "EnrollmentFacts"
  SELECT RUNS."AcademicYearId",
         "ModuleId",
          COUNT("Enrollments"."StudentId")
  FROM "Enrollments"
    INNER JOIN "ModuleRuns" RUNS
      ON "Enrollments"."ModuleRunId" = RUNS."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "EnrollmentFacts"
      WHERE "ModuleDimId" = "ModuleId"
        AND "AcademicYearDimId" = RUNS."AcademicYearId"
    )
  GROUP BY RUNS."AcademicYearId", 
           "ModuleId"
  ORDER BY RUNS."AcademicYearId",
           "ModuleId";
END;

-- GENERATE GENDER FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_GenderFactEtl AS
BEGIN
  INSERT INTO "GenderFacts"
  SELECT UFN_GetCurrentAcademicYear(),
         UFN_GenderDimsGetId("Gender"),
         COUNT("Id")
  FROM "Students"
  WHERE NOT EXISTS(
      SELECT *
      FROM "GenderFacts"
      WHERE "GenderDimId" = UFN_GenderDimsGetId("Gender")
        AND "AcademicYearDimId" = UFN_GetCurrentAcademicYear()
    )
  GROUP BY UFN_GetCurrentAcademicYear(),
           UFN_GenderDimsGetId("Gender")
  ORDER BY UFN_GetCurrentAcademicYear(),
           UFN_GenderDimsGetId("Gender");
END;

-- GENERATE GRADUATION FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_GraduationFactEtl AS
BEGIN
  INSERT INTO "GraduationFacts"
  SELECT "YearId",
         "CourseId",
         COUNT("Id")
  FROM "Graduations"
  WHERE NOT EXISTS(
      SELECT *
      FROM "GraduationFacts"
      WHERE "CourseDimId" = "CourseId"
        AND "AcademicYearDimId" = "YearId"
    )
  GROUP BY "YearId",
           "CourseId"
  ORDER BY "YearId",
           "CourseId";
END;

-- GENERATE LECTURER FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_LecturerFactEtl AS
BEGIN
  INSERT INTO "LecturerFacts"
  SELECT MR."AcademicYearId",
         L."Id",
         AVG(R."Grade")
  FROM "Lecturers" L
  INNER JOIN "ModuleRuns" MR
    ON L."Id" = MR."LecturerId"
  INNER JOIN "Assignments" A
    ON A."ModuleRunId" = MR."Id"
  INNER JOIN "Results" R
    ON R."AssignmentId" = A."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "LecturerFacts"
      WHERE "LecturerDimId" = L."Id"
        AND "AcademicYearDimId" = MR."AcademicYearId"
    )
  GROUP BY "AcademicYearId",
           L."Id"
  ORDER BY "AcademicYearId",
           L."Id";
END;

-- GENERATE MODULE FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_ModuleFactEtl AS
BEGIN
  INSERT INTO "ModuleFacts"
  SELECT UFN_GetCurrentAcademicYear(),
         CM."CourseId",
         COUNT("Id")
  FROM "Modules" M
  INNER JOIN "CourseModules" CM
            ON CM."ModuleId" = M."Id"
  WHERE NOT EXISTS(
      SELECT *
      FROM "ModuleFacts"
      WHERE "CourseDimId" = CM."CourseId"
        AND "AcademicYearDimId" = UFN_GetCurrentAcademicYear()
    )
  GROUP BY UFN_GetCurrentAcademicYear(),
           CM."CourseId"
  ORDER BY UFN_GetCurrentAcademicYear(),
           CM."CourseId";
END;

-- GENERATE RESULT FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_ResultFactEtl AS
BEGIN
  INSERT INTO "ResultFacts"
  SELECT MR."AcademicYearId",
         MR."ModuleId",
         UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(R."Grade")),
         COUNT(R."Id")
  FROM "Results" R
  INNER JOIN "Assignments" A
            ON R."AssignmentId" = A."Id"
  INNER JOIN "ModuleRuns" MR
    ON MR."Id" = A."ModuleRunId"
  WHERE NOT EXISTS(
      SELECT *
      FROM "ResultFacts"
      WHERE "ModuleDimId" = MR."ModuleId"
        AND "ClassificationDimId" = UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(R."Grade"))
        AND "AcademicYearDimId" = UFN_GetCurrentAcademicYear()
    )
  GROUP BY MR."AcademicYearId",
            MR."ModuleId",
            UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(R."Grade"))
  ORDER BY MR."AcademicYearId",
            MR."ModuleId",
            UFN_ClassificationDimsGetId(UFN_MapGradeToClassification(R."Grade"));
END;

-- GENERATE STUDENT FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_StudentFactEtl AS
BEGIN
  INSERT INTO "StudentFacts"
  SELECT UFN_GetCurrentAcademicYear(),
         "CountryId",
         COUNT("Id")
  FROM "Students"
  WHERE NOT EXISTS(
      SELECT *
      FROM "StudentFacts"
      WHERE "CountryDimId" = "CountryId"
        AND "AcademicYearDimId" = UFN_GetCurrentAcademicYear()
    )
  GROUP BY UFN_GetCurrentAcademicYear(),
           "CountryId"
  ORDER BY UFN_GetCurrentAcademicYear(),
           "CountryId";
END;
  
------------------------------
---- COMPILED ETL PROCESS ----
------------------------------

CREATE OR REPLACE PROCEDURE S1509508.USP_Etl AS
BEGIN
  -------------------------------
  ---- INITIALIZE DIMENSIONS ----
  -------------------------------
  USP_AcademicYearDims();
  USP_CampusDims();
  USP_CountryDims();
  USP_CourseDims();
  USP_LecturerDims();
  USP_ModuleDims();
  USP_ClassificationDimsEtl();
  USP_GenderDimsEtl();

  ------------------------
  ---- GENERATE FACTS ----
  ------------------------
  USP_AssignmentFactEtl();
  USP_ComplaintFactEtl();
  USP_CourseFactEtl();
  USP_EnrollmentFactEtl();
  USP_GenderFactEtl();
  USP_GraduationFactEtl();
  USP_LecturerFactEtl();
  USP_ModuleFactEtl();
  USP_ResultFactEtl();
  USP_StudentFactEtl();
END;

---- THIS ASSIGMENT BROUGHT TO YOU ----
----    BY THE HEALING POWERS OF   ----
---------------------------------------
--   88                                 
--   ""                                                                
--   88 ,adPPYYba, 888888888 888888888  
--   88 ""     `Y8      a8P"      a8P"  
--   88 ,adPPPPP88   ,d8P'     ,d8P'    
--   88 88,    ,88 ,d8"      ,d8"       
--   88 `"8bbdP"Y8 888888888 888888888  
 -- ,88                                 
--888P"           
---------------------------------------