﻿CREATE PROCEDURE [dbo].[SP_UpDateEstCompleteTache]
    @IdTache INT,
    @EstComplete BIT
AS
BEGIN
    UPDATE Tache 
    SET EstComplete = @EstComplete
    WHERE IdTache = @IdTache;
END

