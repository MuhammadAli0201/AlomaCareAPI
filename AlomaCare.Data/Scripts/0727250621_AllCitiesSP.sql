﻿CREATE PROCEDURE GetAllCities
AS
BEGIN
    SELECT * 
    FROM Cities
	WHERE IsDeleted = 0
END