---- OPERATIONAL --> DIMENSIONAL EXTRACTIONS [DIMS] ----

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