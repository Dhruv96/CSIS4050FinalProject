CREATE TABLE [dbo].[Passenger]
(
	[PassengerId] INT NOT NULL,
    [FirstName] NCHAR(10) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    [Email] NCHAR(10) NOT NULL,
    CONSTRAINT PK_PERSON PRIMARY KEY ([PassengerId])
);
