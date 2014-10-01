CREATE PROCEDURE [dbo].[GetGuestRecords]
	@from int = 0,
	@to int = 25
AS

SELECT * 
	FROM (
		SELECT *, Rank() 
			OVER (ORDER BY [PostDate] DESC) AS Rank
		FROM [GuestRecords]
		) rs WHERE Rank >= @from AND Rank <= @to