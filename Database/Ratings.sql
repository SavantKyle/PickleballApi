CREATE TABLE [dbo].[Ratings]
(
	[Id] INT NOT NULL identity constraint PK_Rating PRIMARY KEY (Id), 
    [Rate] VARCHAR(5) NOT NULL
)
