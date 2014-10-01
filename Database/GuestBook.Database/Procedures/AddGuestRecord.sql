CREATE PROCEDURE [AddGuestRecord]
	@username NVARCHAR(255),
	@usermail NVARCHAR(255),
	@messages TEXT,
	@homepage VARCHAR(512),
	@ipaddres VARCHAR(10),
	@useragent NVARCHAR(512),
	@browsername NVARCHAR(50),
	@browserversion NVARCHAR(10)
AS
BEGIN
	
	IF NOT EXISTS (SELECT * FROM [GuestBrowser] WHERE UserAgent = @useragent)
	BEGIN
		INSERT INTO [GuestBrowser] (BrowserName, BrowserVersion, UserAgent) VALUES (@browsername, @browserversion, @useragent)
	END

	DECLARE @kbrowser INT
	SELECT @kbrowser = [Id] FROM [GuestBrowser] WHERE UserAgent = @useragent 

	INSERT INTO [GuestRecords] (UserName, UserMail, Messages, Homepage, IpAddres, KBrowser) VALUES (@username, @usermail, @messages, @homepage, @ipaddres, @kbrowser)	
END
