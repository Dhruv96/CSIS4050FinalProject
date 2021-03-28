CREATE TABLE [dbo].[Flight]
(
	[FlightId] INT NOT NULL, 
    [AirlineId] INT NOT NULL, 
    [DepartureAirport] INT NOT NULL, 
    [DestinationAirport] INT NOT NULL, 
    [FlightDate] DATETIME NOT NULL, 
    [Price] MONEY NOT NULL, 
    [NumSeats] INT NOT NULL,
    CONSTRAINT PK_FLIGHT PRIMARY KEY ([FlightId])
);
