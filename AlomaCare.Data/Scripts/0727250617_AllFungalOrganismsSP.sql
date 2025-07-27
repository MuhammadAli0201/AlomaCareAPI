CREATE PROCEDURE GetAllFungalOrganisms
AS
BEGIN
    SELECT * 
    FROM FungalOrganisms
	WHERE IsDeleted = 0
END

