CREATE PROCEDURE [dbo].[SP_UpDateTache]
    @IdTache int,
    @Statut bit,
    @NomTache varchar(50),
    @Recurrence varchar(50),
    @Priorite int,
    @Description varchar(max),
    @DateDebut datetime,
    @DateFin datetime,
    @DateEcheance datetime,
    @TachePartagee bit,
    @EstComplete bit
AS
BEGIN
    UPDATE Tache 
    SET 
        Statut = @Statut,
        NomTache = @NomTache,
        Recurrence = @Recurrence,
        Priorite = @Priorite,
        Description = @Description,
        DateDebut = @DateDebut,
        DateFin = @DateFin,
        DateEcheance = @DateEcheance,
        TachePartagee = @TachePartagee,
        EstComplete = @EstComplete
    WHERE IdTache = @IdTache;
END


-- cette procédure peut-être utlisée pour ne mettre à jour que qlq champs 
--exemple : 
-- EXEC SP_UpDateTache @IdTache = 1, @Priorite = 2