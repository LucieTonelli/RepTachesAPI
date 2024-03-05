CREATE PROCEDURE [dbo].[SP_CreateTache]
    @NomTache varchar(50),
    @Recurrence int,
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


--CREATE PROCEDURE [dbo].[SP_CreateTache]
--    @NomTache VARCHAR(50),
--    @Recurrence INT,
--    @Priorite INT,
--    @Description VARCHAR(MAX),
--    @TachePartagee BIT,
--    @Utilisateur INT  -- Changer le type de données en INT pour correspondre à l'IdUtilisateur

--AS
--BEGIN
--    DECLARE @NewId INT;

--    INSERT INTO Tache (NomTache, Recurrence, Priorite, Description, TachePartagee, IdUtilisateur)
--    VALUES (@NomTache, @Recurrence, @Priorite, @Description, @TachePartagee, @Utilisateur);

--    SET @NewId = SCOPE_IDENTITY();

--    SELECT @NewId AS NewId;
--END;
