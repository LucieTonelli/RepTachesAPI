CREATE PROCEDURE [dbo].[SP_CreateTache]
    @NomTache varchar(50),
    @Recurrence varchar(50),
    @Priorite int,
    @Description varchar(max),
    @TachePartagee bit
    
AS
BEGIN

    INSERT INTO Tache (NomTache, Recurrence, Priorite, Description, TachePartagee)
    VALUES (@NomTache, @Recurrence, @Priorite, @Description, @TachePartagee);
    DECLARE @NewId int
    SET @NewId = SCOPE_IDENTITY()
    SELECT @NewId AS NewId
END

