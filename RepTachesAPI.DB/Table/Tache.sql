CREATE TABLE [dbo].[Tache]
(
	[IdTache] INT IDENTITY(1,1),
    [Statut] BIT DEFAULT 1 NOT NULL,
    [NomTache] VARCHAR(50) NOT NULL,
    [Recurrence] VARCHAR(50) DEFAULT 'Non',
    [Priorite] INT DEFAULT '1',
    [Description] VARCHAR(50),
    [DateCreation] TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    [DateDebut] DATETIME,
    [DateFin] DATETIME,
    [DateEcheance] DATETIME,
    [TachePartagee] BIT DEFAULT '1' NOT NULL,
    [EstComplete] BIT DEFAULT '0' NOT NULL,

    CONSTRAINT [PK_Tache] PRIMARY KEY (IdTache),
	CONSTRAINT [UC_Tache] UNIQUE (NomTache),
    CONSTRAINT [FK_Tache_Utilisateur] FOREIGN KEY (IdTache) REFERENCES Utilisateur(IdUtilisateur),



)

GO

CREATE TRIGGER [dbo].[Trigger_Tache]
    ON [dbo].[Tache]
    FOR DELETE, INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON
    END