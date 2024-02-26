CREATE TABLE [dbo].[Utilisateur_tache]
(
    [IdUtilisateur] INT NOT NULL,
    [IdTache] INT NOT NULL,
    
    
    
    CONSTRAINT [PK_Utilisateur_tache] PRIMARY KEY (IdUtilisateur, IdTache),
    CONSTRAINT [FK_Utilisateur_tache_Utilisateur] FOREIGN KEY (IdUtilisateur) REFERENCES Utilisateur(IdUtilisateur),
    CONSTRAINT [FK_Utilisateur_tache_Tache] FOREIGN KEY (IdTache) REFERENCES Tache(IdTache)
)

