CREATE PROCEDURE [dbo].[DeleteTache]
    @IdTache INT
AS
BEGIN
    DELETE FROM Tache WHERE IdTache = @IdTache;
END
