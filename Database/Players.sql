CREATE TABLE [dbo].[Players]
(
	[Id] INT NOT NULL identity constraint PK_Player PRIMARY KEY (Id), 
    [FirstName] VARCHAR(100) NOT NULL, 
    [LastName] VARCHAR(100) NOT NULL, 
	[BirthYear] INT NOT NULL,
	[Gender] INT NOT NULL,
    [Email] VARCHAR(200) NOT NULL, 
    [Phone] VARCHAR(13) NOT NULL, 
	[EventsPlaying] INT NULL, 
    [SinglesRatingId] INT NULL constraint FK_Player_SinglesRating foreign key references Ratings(Id), 
	[DoublesRatingId] INT NULL constraint FK_Player_DoublesRating foreign key references Ratings(Id), 
	[MixedRatingId] INT NULL constraint FK_Player_MixedRating foreign key references Ratings(Id), 
    [DoublesPartnerId] INT NULL constraint FK_Player_DoublesPartner foreign key references Partners(Id),
	[MixedPartnerId] INT NULL constraint FK_Player_MixedPartner foreign key references Partners(Id), 
    [CrawfishGuests] INT NOT NULL DEFAULT 0
)
