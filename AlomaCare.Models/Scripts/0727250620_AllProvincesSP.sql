CREATE PROCEDURE GetAllProvinces
AS
BEGIN
    SELECT * 
    FROM Provinces
	WHERE IsDeleted = 0
END