CREATE VIEW [dbo].[V_Admin_TachesEnCours]
AS
SELECT 
    U.IdUtilisateur,
    U.Username,
    U.DateDerniereConnexion,
    COUNT(CASE WHEN T.EstComplete = 0 THEN 1 ELSE NULL END) AS TachesEnCours,
    COUNT(CASE WHEN T.EstComplete = 1 THEN 1 ELSE NULL END) AS TachesTerminees
FROM
    Utilisateur U
LEFT JOIN
    Utilisateur_tache UT ON U.IdUtilisateur = UT.IdUtilisateur
LEFT JOIN
    Tache T ON UT.IdTache = T.IdTache
WHERE U.IdUtilisateur = @IdUtilisateur