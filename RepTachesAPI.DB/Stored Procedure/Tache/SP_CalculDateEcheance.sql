CREATE PROCEDURE [dbo].[SP_CalculDateEcheance]
    @DateCreation DATETIME,
    @Priorite INT,
    @IdTache INT
AS
BEGIN
    DECLARE @DaysToAdd AS INT;

    IF @Priorite = 1
        SET @DaysToAdd = 14;
    ELSE IF @Priorite = 2
        SET @DaysToAdd = 7;
    ELSE IF @Priorite = 3
        SET @DaysToAdd = 3;
    ELSE IF @Priorite = 4
        SET @DaysToAdd = 1;

    DECLARE @DateEcheance AS DATETIME;
    SET @DateEcheance = DATEADD(DAY, @DaysToAdd, @DateCreation);
    UPDATE Tache 
    SET DateEcheance = @DateEcheance
    WHERE IdTache = @IdTache;
END