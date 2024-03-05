CREATE TABLE [dbo].[Tache]
(
	[IdTache] INT IDENTITY(1,1),
    [Statut] BIT DEFAULT 1 NOT NULL,
    [NomTache] VARCHAR(50) NOT NULL,
    [Recurrence] VARCHAR(50) DEFAULT 'Non',
    [Priorite] INT DEFAULT '1',
    [Description] VARCHAR(MAX),
    [DateCreation] DATETIME DEFAULT GetDate(),
    [DateDebut] DATETIME DEFAULT NULL,
    [DateFin] DATETIME DEFAULT NULL,
    [DateEcheance] DATETIME,
    [TachePartagee] BIT DEFAULT '0' NOT NULL,
    [EstComplete] BIT DEFAULT '0' NOT NULL,

    CONSTRAINT [PK_Tache] PRIMARY KEY (IdTache),
	CONSTRAINT [UC_Tache] UNIQUE (NomTache),




)

GO

CREATE TRIGGER [dbo].[Trigger_Tache_SolftDelete]
    ON [dbo].[Tache]
    INSTEAD OF DELETE
    AS
    BEGIN
        SET NOCOUNT ON;
        DECLARE @IdTache INT;
        SELECT @IdTache = @IdTache
        FROM DELETED;
		UPDATE Tache
        SET Statut = 0
        WHERE @IdTache = @IdTache;
    END

