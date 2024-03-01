CREATE PROCEDURE [dbo].[CreateTache]
    @Statut INT,
    @NomTache NVARCHAR(50),
    @Recurrence NVARCHAR(50),
    @Priorite INT,
    @Description NVARCHAR(255),
    @DateCreation DATETIME,
    @DateDebut DATETIME,
    @DateFin DATETIME,
    @DateEcheance DATETIME,
    @TachePartagee BIT,
    @EstComplete BIT
AS
BEGIN
    INSERT INTO Tache (Statut, NomTache, Recurrence, Priorite, Description, DateCreation, DateDebut, DateFin, DateEcheance, TachePartagee, EstComplete)
    VALUES (@Statut, @NomTache, @Recurrence, @Priorite, @Description, @DateCreation, @DateDebut, @DateFin, @DateEcheance, @TachePartagee, @EstComplete);
    SELECT SCOPE_IDENTITY() AS IdTache;
END
