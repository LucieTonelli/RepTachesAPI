﻿CREATE PROCEDURE [dbo].[UpdateEstComplete]
    @IdTache INT,
    @EstComplete BIT
AS
BEGIN
    UPDATE Tache 
    SET EstComplete = @EstComplete
    WHERE IdTache = @IdTache;
END

