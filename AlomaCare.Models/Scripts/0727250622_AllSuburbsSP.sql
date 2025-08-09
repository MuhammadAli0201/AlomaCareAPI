CREATE PROCEDURE GetAllSuburbs
AS
BEGIN
    SELECT * 
    FROM Suburbs
	WHERE IsDeleted = 0
END