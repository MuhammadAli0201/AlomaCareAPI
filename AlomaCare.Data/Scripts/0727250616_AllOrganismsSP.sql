CREATE PROCEDURE GetAllOrganisms
AS
BEGIN
    SELECT * 
    FROM organisms
	WHERE IsDeleted = 0
END

