CREATE PROCEDURE [dbo].[SP_HashPassword]
    @Username VARCHAR(50),
    @Password VARCHAR(50),
    @Result VARCHAR(64) OUTPUT
AS
BEGIN
    DECLARE @Salt VARCHAR(16);
    SET @Salt = CONVERT(VARCHAR(16), NEWID());

    DECLARE @Pepper VARCHAR(16);
    SET @Pepper = CONVERT(VARCHAR(16), NEWID());

    SET @Password = @Salt + @Password + @Pepper;

    SET @Result = CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', @Password), 2);
END