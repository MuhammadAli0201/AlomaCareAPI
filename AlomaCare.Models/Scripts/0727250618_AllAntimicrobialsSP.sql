CREATE PROCEDURE GetAllFungalAntimicrobials
AS
BEGIN
    SELECT * 
    FROM Antimicrobials
	WHERE IsDeleted = 0
END