CREATE PROCEDURE GetAllHospitals
AS
BEGIN
    SELECT * 
    FROM Hospitals
	WHERE IsDeleted = 0
END