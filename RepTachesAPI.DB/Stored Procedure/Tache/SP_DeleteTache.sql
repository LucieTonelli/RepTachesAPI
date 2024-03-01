CREATE PROCEDURE [dbo].[SP_DeleteTache]
    @IdTache INT
AS
BEGIN
    DELETE FROM Tache WHERE IdTache = @IdTache;
END
