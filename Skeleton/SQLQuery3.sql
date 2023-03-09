USE [p2677680]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_Customer_Update]

SELECT	@return_value as 'Return Value'

GO
