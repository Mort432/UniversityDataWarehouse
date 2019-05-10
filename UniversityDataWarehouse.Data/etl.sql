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
  END;
  
-- CONVERT RESULT GRADE VALUE --> CLASSIFICATION DIM STRING
CREATE OR REPLACE FUNCTION S1509508.UFC_MapGradeToClassification(grade in NUMBER) RETURN NVARCHAR2 AS
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
      CURRENT_DATE >= "AcademicYearStart"
      AND CURRENT_DATE < "AcademicYearEnd";
  end;

---------------------------------------------------------
---- OPERATIONAL --> DIMENSIONAL EXTRACTIONS [FACTS] ----
---------------------------------------------------------

-- GENERATE ASSIGNMENT FACTS
CREATE OR REPLACE PROCEDURE S1509508.USP_AssignmentFactEtl AS
  BEGIN
    INSERT INTO "AssignmentFacts"
    SELECT "ModuleId",
           RUNS."AcademicYearId",
           COUNT("Assignments"."Id")
    FROM "Assignments"
      INNER JOIN "ModuleRuns" RUNS
        ON "Assignments"."ModuleRunId" = RUNS."Id"
    WHERE NOT EXISTS(
      SELECT *
      FROM "AssignmentFacts"
      WHERE "ModuleDimId" = "ModuleId"
      AND "AcademicYearDimId" = YEARS."Id"
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
  SELECT "CourseId",
         "AcademicYearId",
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
  SELECT "CourseId",
         "AcademicYearId",
         COUNT("Complaints"."Id")
  FROM "Courses"
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