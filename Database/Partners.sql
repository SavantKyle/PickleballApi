CREATE TABLE [dbo].[Partners]
(
	[Id] INT NOT NULL identity constraint PK_Partner PRIMARY KEY (Id), 
    [FirstName] VARCHAR(100) NULL, 
    [LastName] VARCHAR(100) NULL, 
    [Phone] VARCHAR(13) NULL, 
	[PlayerId] INT NULL constraint FK_Partner_Player foreign key references Players(Id) 
)
