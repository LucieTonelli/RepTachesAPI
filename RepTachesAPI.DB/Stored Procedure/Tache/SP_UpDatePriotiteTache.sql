CREATE PROCEDURE [dbo].[SP_UpDatePriotiteTache]
	@IdTache int,
	@Priorite int
AS
BEGIN 
	UPDATE Tache 
    SET Priorite = @Priorite
    WHERE IdTache = @IdTache;
END





