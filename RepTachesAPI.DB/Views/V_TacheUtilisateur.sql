CREATE VIEW [dbo].[V_TacheUtilisateur]
AS 
SELECT	NomTache,
		[Description],
		Priorite,
		DateEcheance
FROM Tache
WHERE	Statut = 1 AND EstComplete = 0
