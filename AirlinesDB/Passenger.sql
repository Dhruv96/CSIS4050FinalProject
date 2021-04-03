CREATE TABLE [dbo].[Passenger]
(
	[PassengerId] INT NOT NULL,
    [FirstName] NCHAR(25) NOT NULL, 
    [LastName] NCHAR(25) NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    [Email] NCHAR(50) NOT NULL,
    CONSTRAINT PK_PERSON PRIMARY KEY ([PassengerId])
);
