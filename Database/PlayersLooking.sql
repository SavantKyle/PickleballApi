CREATE TABLE [dbo].[PlayersLooking]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Gender] varchar(6) NULL,
	[DoublesRating] varchar(4) null, 
	[MixedRating] varchar(4) null, 
	[Age] INT NULL, 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] VARCHAR(100) NULL, 
    [Phone] VARCHAR(13) NULL, 
    [Email] VARCHAR(100) NULL, 
    [EventNeedingPartner] varchar(7) NULL
)
