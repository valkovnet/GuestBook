﻿CREATE TABLE [dbo].[GuestRecords]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY CLUSTERED,
	[UserName] VARCHAR(255) NOT NULL,
	[UserMail] VARCHAR(255) NOT NULL,
	[Homepage] VARCHAR(512),
	[PostDate] DATETIME NOT NULL DEFAULT(GETDATE()),
	[Messages] TEXT NOT NULL,
	[IpAddres] VARCHAR(10) NOT NULL,
	[KBrowser] INT NOT NULL,
	[IsDelete] BIT DEFAULT(0) NOT NULL
	CONSTRAINT FK_BrowserInfo FOREIGN KEY ([KBrowser]) REFERENCES [GuestBrowser](Id)
)
