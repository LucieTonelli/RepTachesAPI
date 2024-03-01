CREATE PROCEDURE [dbo].[CreateUtilisateur]
    @Statut INT,
    @Role VARCHAR,
	@Username VARCHAR,
	@Nom VARCHAR,
	@Prenom VARCHAR,
	@DateNaissance DATE,
	@Email VARCHAR,
	@Telephone VARCHAR,
	@Passeword VARCHAR,
	@DateDerniereConnexion DATETIME
AS
BEGIN
    INSERT INTO Utilisateur (Role, Username, Nom, Prenom, DateNaissance, Email, Telephone, Passeword, DateDerniereConnexion)
    VALUES (@Role, @Username, @Nom, @Prenom, @DateNaissance, @Email, @Telephone, @Passeword, @DateDerniereConnexion);
    SELECT SCOPE_IDENTITY() AS IdUtilisateur;
END
