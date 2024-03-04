CREATE PROCEDURE [dbo].[SP_UpDateUtilisateurTache]
    @IdTache INT,
    @IdUtilisateur INT
AS
BEGIN

    IF EXISTS (SELECT 1 FROM Utilisateur_tache WHERE IdTache = @IdTache AND IdUtilisateur = @IdUtilisateur)
    BEGIN
        PRINT 'L''utilisateur est déjà lié à la tâche.'
    END
    ELSE
    BEGIN
        INSERT INTO Utilisateur_tache (IdTache, IdUtilisateur)
        VALUES (@IdTache, @IdUtilisateur);
    END
END

