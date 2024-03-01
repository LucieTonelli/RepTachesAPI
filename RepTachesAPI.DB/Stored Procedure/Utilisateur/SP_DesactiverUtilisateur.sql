CREATE PROCEDURE [dbo].[SP_DesactiverUtilisateur]
	 @IdUtilisateur INT
AS
BEGIN
    UPDATE Utilisateur
    SET Statut = 0
    WHERE IdUtilisateur = @IdUtilisateur;
END