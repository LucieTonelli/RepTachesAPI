CREATE PROCEDURE [dbo].[SP_UpdateUtilisateur]
    @IdUtilisateur INT,
    @Statut INT,
    @Role VARCHAR(50),
	@Username VARCHAR(50),
	@Nom VARCHAR(50),
	@Prenom VARCHAR(50),
	@DateNaissance DATE,
	@Email VARCHAR(50),
	@Telephone VARCHAR(20),
	@Passeword VARCHAR(50),
	@DateDerniereConnexion DATETIME
AS
BEGIN
    UPDATE Utilisateur
    SET Statut = @Statut,
        Role = @Role,
        Username = @Username,
        Nom = @Nom,
        Prenom = @Prenom,
        DateNaissance = @DateNaissance,
        Email = @Email,
        Telephone = @Telephone,
        Passeword = @Passeword,
        DateDerniereConnexion = @DateDerniereConnexion
    WHERE IdUtilisateur = @IdUtilisateur;
END
