CREATE PROCEDURE GetAllSonarFindings
AS
BEGIN
    SELECT * 
    FROM SonarFindings
	WHERE IsDeleted = 0
END