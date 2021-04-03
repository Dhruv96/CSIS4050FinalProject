CREATE TABLE [dbo].[Booking]
(
	[BookingId] INT NOT NULL, 
    [PassengerId] INT NOT NULL, 
    [BaggageFee] MONEY NOT NULL, 
    [ServiceFee] MONEY NOT NULL, 
    [TotalFee] MONEY NOT NULL, 
    [isRoundTrip] BIT NOT NULL
    CONSTRAINT PK_BOOKING PRIMARY KEY (BookingId, PassengerId),
);
