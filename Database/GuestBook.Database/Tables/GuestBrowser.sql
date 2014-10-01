CREATE TABLE [dbo].[GuestBrowser]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	[BrowserName] NVARCHAR(50),
	[BrowserVersion] NVARCHAR(10),
	[UserAgent] NVARCHAR(512)
)
