CREATE TABLE [dbo].[FlightBooking]
(
	[BookingId] INT NOT NULL, 
    [PassengerId] INT NOT NULL,
    [SeatNum] INT NOT NULL,
    [FlightId] INT NOT NULL, 
    CONSTRAINT PK_FLIGHTBOOKING PRIMARY KEY (BookingId,PassengerId, FlightId, SeatNum),
    CONSTRAINT FK_FLIGHTBOOKING_BID FOREIGN KEY(BookingId, PassengerId) REFERENCES Booking(BookingId,PassengerId),
    CONSTRAINT FK_FLIGHTBOOKING_FID FOREIGN KEY (FlightId) REFERENCES Flight(FlightId),
    CONSTRAINT FK_FLIGHTBOOKING_SNUM FOREIGN KEY(SeatNum, FlightId) REFERENCES Seat(SeatNum, FlightId)
);
