CREATE TABLE [dbo].[Utilisateur]
(
	[IdUtilisateur] INT IDENTITY(1,1),
	[Statut] BIT DEFAULT 1 NOT NULL,
	[Role] VARCHAR(50) DEFAULT 'standard' NOT NULL,
	[Username] VARCHAR(10) NOT NULL,
	[Nom] VARCHAR(50),
	[Prenom] VARCHAR(50),
	[DateNaissance] DATE,
	[Email] VARCHAR(50),
	[Telephone] VARCHAR(50),
	[Passeword] VARCHAR(50) NOT NULL, 
	[DateDerniereConnexion] TIMESTAMP DEFAULT CURRENT_TIMESTAMP,


    CONSTRAINT [PK_Utilisateur] PRIMARY KEY (IdUtilisateur),
	CONSTRAINT [UC_Utilisateur] UNIQUE (Username), 
    CONSTRAINT [FK_Utilisateur_Tache] FOREIGN KEY (IdUtilisateur) REFERENCES Tache(IdTache),



)
