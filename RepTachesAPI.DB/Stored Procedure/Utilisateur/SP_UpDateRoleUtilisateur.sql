CREATE PROCEDURE [dbo].[SP_UpdateRoleUtilisateur]
    @IdUtilisateur INT,
    @Role VARCHAR(50)
AS
BEGIN
    UPDATE Utilisateur
    SET Role = @Role
    WHERE IdUtilisateur = @IdUtilisateur;
END
