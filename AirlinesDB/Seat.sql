CREATE TABLE [dbo].[Seat]
(
	[SeatNum] INT NOT NULL, 
    [FlightId] INT NOT NULL, 
    [isBooked] INT NOT NULL
    CONSTRAINT PK_SEAT PRIMARY KEY (SeatNum, FlightId)
    CONSTRAINT FK_SEAT FOREIGN KEY (FlightId) REFERENCES Flight(FlightId)
    ON DELETE CASCADE
);
