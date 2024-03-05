/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET IDENTITY_INSERT Tache ON;
INSERT INTO Tache (IdTache, Statut, NomTache, Recurrence, Priorite, Description, DateCreation, DateDebut, DateFin, DateEcheance, TachePartagee, EstComplete) VALUES
(1, 1, 'Nettoyage de la salle de bain', 0, 1, 'Nettoyer les toilettes, le lavabo, la baignoire et le sol', '2024-02-23 00:00:00', '2024-02-24 09:00:00', '2024-02-24 10:00:00', '2024-02-24 10:00:00', 1, 0),
(2, 1, 'Nettoyage de la cuisine', 0, 2, 'Nettoyer les surfaces, la vaisselle, les appareils électroménagers et le sol', '2024-02-23 00:00:00', '2024-02-25 14:00:00', '2024-02-25 15:00:00', '2024-02-25 15:00:00', 1, 0),
(3, 1, 'Aspirateur dans le salon', 0, 3, 'Passer l''aspirateur dans le salon et sous les meubles', '2024-02-23 00:00:00', '2024-02-26 09:00:00', '2024-02-27 17:00:00', '2024-02-27 17:00:00', 1, 0),
(4, 1, 'Rangement des chambres', 0, 4, 'Ranger les vêtements, les jouets et les livres dans les chambres', '2024-02-23 00:00:00', '2024-02-28 10:00:00', '2024-02-28 12:00:00', '2024-02-28 12:00:00', 1, 0),
(5, 1, 'Sortir les poubelles', 0, 5, 'Sortir les poubelles et les mettre dans les bacs de recyclage', '2024-02-23 00:00:00', '2024-02-29 09:00:00', '2024-02-29 16:00:00', '2024-02-29 16:00:00', 1, 0),
(6, 1, 'Laver la voiture', 0, 6, 'Laver la voiture et la faire briller', '2024-02-23 00:00:00', '2024-03-01 09:00:00', '2024-03-01 12:00:00', '2024-03-01 12:00:00', 1, 0),
(7, 1, 'Faire les courses', 0, 7, 'Faire les courses hebdomadaires', '2024-02-23 00:00:00', '2024-03-02 09:00:00', '2024-03-02 12:00:00', '2024-03-02 12:00:00', 1, 0),
(8, 1, 'Sortir les chiens', 0, 8, 'Sortir les chiens pour une promenade', '2024-02-23 00:00:00', '2024-03-03 09:00:00', '2024-03-03 10:00:00', '2024-03-03 10:00:00', 1, 0);

SET IDENTITY_INSERT Tache OFF;

SET IDENTITY_INSERT Utilisateur ON;
INSERT INTO Utilisateur (IdUtilisateur, Statut, Role, Username, Nom, Prenom, DateNaissance, Email, Telephone, Passeword, DateDerniereConnexion) VALUES
(1, 1, 'admin', 'admin', 'Admin', 'Admin', '1990-01-01', 'admin@example.com', '123456789', 'admin', '2024-02-23 00:00:00'),
(2, 1, 'standard', 'camille', 'Camille', '', '2000-01-01', 'camille@example.com', '987654321', 'password1', '2024-02-23 00:00:00'),
(3, 1, 'standard', 'baptiste', 'Baptiste', '', '2002-02-02', 'baptiste@example.com', '123123123', 'password2', '2024-02-23 00:00:00'),
(4, 1, 'standard', 'audan', 'Audan', '', '2004-03-03', 'audan@example.com', '456456456', 'password3', '2024-02-23 00:00:00'),
(5, 1, 'standard', 'celestine', 'Célestine', '', '2006-04-04', 'celestine@example.com', '789789789', 'password4', '2024-02-23 00:00:00'),
(6, 1, 'standard', 'constance', 'Constance', '', '2008-05-05', 'constance@example.com', '159159159', 'password5', '2024-02-23 00:00:00'),
(7, 1, 'standard', 'clarisse', 'Clarisse', '', '2010-06-06', 'clarisse@example.com', '357357357', 'password6', '2024-02-23 00:00:00'),
(8, 1, 'standard', 'papa', 'Papa', '', '1975-01-01', 'papa@example.com', '654987321', 'password7', '2024-02-23 00:00:00'),
(9, 1, 'standard', 'maman', 'Maman', '', '1980-01-01', 'maman@example.com', '987654159', 'password8', '2024-02-23 00:00:00');

SET IDENTITY_INSERT Utilisateur OFF;

INSERT INTO Utilisateur_tache (IdUtilisateur, IdTache) VALUES
(2, 1),
(3, 2),
(4, 3),
(5, 4),
(6, 5),
(7, 1),
(7, 2),
(7, 3),
(7, 4),
(7, 5),
(8, 6),
(8, 7),
(9, 8);
