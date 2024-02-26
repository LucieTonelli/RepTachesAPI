CREATE VIEW [dbo].[V_Utilisateur]
AS 
SELECT	IdUtilisateur,
		Nom,
		Prenom,
		[Role],
		DateDerniereConnexion
FROM dbo.Utilisateur
WHERE Statut = 1
