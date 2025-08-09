CREATE PROCEDURE GetAllCongenitalInfectionOrganisms
AS
BEGIN
    SELECT * 
    FROM CongenitalInfectionOrganisms
	WHERE IsDeleted = 0
END