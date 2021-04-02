using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineBookingCodeFirstFromDB
{
    public static class SeedDatabaseExtensionMethods
    {
        public static void SeedDatabase(this AirlineEntities context)
        {
            context.Database.Log = (s => Debug.Write(s));

            // reset the db
            context.Database.Delete();
            context.Database.Create();
            context.SaveChanges();

            context.Airlines.Load();
            context.Passengers.Load();
            context.Flights.Load();
            context.Airports.Load();
            context.Bookings.Load();
            context.FlightBookings.Load();
            context.Seats.Load();

            List<Airport> airports = new List<Airport>()
            {
                new Airport{AirportId = 1, AirportName = "Vancouver International Airport"}, //Canada
                new Airport{AirportId = 2, AirportName = "Indira Gandhi International Airport"}, //India
                new Airport{AirportId = 3, AirportName = "Benito Juarez International Airport"}, //Mexico
                new Airport{AirportId = 4, AirportName = "Beijing Capital International Airport"}, //China
                new Airport{AirportId = 5, AirportName = "Los Angeles International Airport"}, //United States
                new Airport{AirportId = 6, AirportName = "Dubai International Airport"}, //UAE
                new Airport{AirportId = 7, AirportName = "Heathrow International Airport"}, //UK
                new Airport{AirportId = 8, AirportName = "Tokyo Haneda Airport"}, //Japan
                new Airport{AirportId = 9, AirportName = "Charles de Gaulle Airport"}, //France
                new Airport{AirportId = 10, AirportName = "Amsterdam Airport Schiphol"}, //Netherlands
                new Airport{AirportId = 11, AirportName = "Seoul Incheon International Airport"}, //South Korea
                new Airport{AirportId = 12, AirportName = "Frankfurt Airport"}, //Germany
                new Airport{AirportId = 13, AirportName = "Singapore Changi Airport"}, //Singapore
                new Airport{AirportId = 14, AirportName = "Suvarnabhumi Airport"}, //Thailand
                new Airport{AirportId = 15, AirportName = "Kuala Lumpur International Airport"}, //Malaysia
                new Airport{AirportId = 16, AirportName = "Madrid Barajas Airport"}, //Spain
                new Airport{AirportId = 17, AirportName = "Soekarno Hatta International Airport"}, //Indonesia
                new Airport{AirportId = 18, AirportName = "Istanbul Airport"}, //Turkey
                new Airport{AirportId = 19, AirportName = "Sydney Kingsford-Smith Airport"}, //Australia
                new Airport{AirportId = 20, AirportName = "Sheremetyevo International Airport"}, //Russia
            };

            List<Airline> airlines = new List<Airline>()
            {
                new Airline{AirlineId=1, AirlineName = "Air Canada"}, //Canada
                new Airline{AirlineId=2, AirlineName = "Air India"}, //India
                new Airline{AirlineId=3, AirlineName = "Aero Mexico"},//Mexico
                new Airline{AirlineId=4, AirlineName = "Air China"}, //China
                new Airline{AirlineId=5, AirlineName = "Delta Airlines"}, //United States
                new Airline{AirlineId=6, AirlineName = "Etihad Airlines"}, //UAE
                new Airline{AirlineId=7, AirlineName = "British Airways"}, //UK
                new Airline{AirlineId=8, AirlineName = "Japan Airlines"}, //Japan
                new Airline{AirlineId=9, AirlineName = "Air France"}, //France
                new Airline{AirlineId=10, AirlineName = "KLM Royal Dutch Airlines"}, //Netherlands
                new Airline{AirlineId=11, AirlineName = "Korean Air"}, //South Korea
                new Airline{AirlineId=12, AirlineName = "Lufthansa"}, //Germany
                new Airline{AirlineId=13, AirlineName = "Singapore Airlines"}, //Singapore
                new Airline{AirlineId=14, AirlineName = "Thai Airways International"}, //Thailand
                new Airline{AirlineId=15, AirlineName = "Malaysia Airlines"}, //Malaysia
                new Airline{AirlineId=16, AirlineName = "Iberia"}, //Spain
                new Airline{AirlineId=17, AirlineName = "Garuda"}, //Indonesia
                new Airline{AirlineId=18, AirlineName = "Turkish Airlines"}, //Turkey
                new Airline{AirlineId=19, AirlineName = "Qantas Airways"}, //Australia
                new Airline{AirlineId=20, AirlineName = "Aeroflot"}, //Russia
            };

            List<Flight> flights = new List<Flight>()
            {
                new Flight{FlightId=1, AirlineId=1, DepartureAirport=1, DestinationAirport=2, FlightDate = new DateTime(2021,04,11,1,50,00), Price = 933, NumSeats = 20},
                new Flight{FlightId=2, AirlineId=2, DepartureAirport=2, DestinationAirport=3, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1315, NumSeats = 20},
                new Flight{FlightId=3, AirlineId=3, DepartureAirport=3, DestinationAirport=4, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1207, NumSeats = 20},
                new Flight{FlightId=4, AirlineId=4, DepartureAirport=4, DestinationAirport=5, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1156, NumSeats = 20},
                new Flight{FlightId=5, AirlineId=5, DepartureAirport=5, DestinationAirport=6, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1059, NumSeats = 20},
                new Flight{FlightId=6, AirlineId=6, DepartureAirport=6, DestinationAirport=7, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 977, NumSeats = 20},
                new Flight{FlightId=7, AirlineId=7, DepartureAirport=7, DestinationAirport=8, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 767, NumSeats = 20},
                new Flight{FlightId=8, AirlineId=8, DepartureAirport=8, DestinationAirport=9, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1234, NumSeats = 20},
                new Flight{FlightId=9, AirlineId=9, DepartureAirport=9, DestinationAirport=10, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1365, NumSeats = 20},
                new Flight{FlightId=10, AirlineId=10, DepartureAirport=10, DestinationAirport=11, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1469, NumSeats = 20},
                new Flight{FlightId=11, AirlineId=11, DepartureAirport=11, DestinationAirport=12, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1132, NumSeats = 20},
                new Flight{FlightId=12, AirlineId=12, DepartureAirport=12, DestinationAirport=13, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1278, NumSeats = 20},
                new Flight{FlightId=13, AirlineId=13, DepartureAirport=13, DestinationAirport=14, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1089, NumSeats = 20},
                new Flight{FlightId=14, AirlineId=14, DepartureAirport=14, DestinationAirport=15, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1455, NumSeats = 20},
                new Flight{FlightId=15, AirlineId=15, DepartureAirport=15, DestinationAirport=16, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 989, NumSeats = 20},
                new Flight{FlightId=16, AirlineId=16, DepartureAirport=16, DestinationAirport=17, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1170, NumSeats = 20},
                new Flight{FlightId=17, AirlineId=17, DepartureAirport=17, DestinationAirport=18, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1120, NumSeats = 20},
                new Flight{FlightId=18, AirlineId=18, DepartureAirport=18, DestinationAirport=19, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 930, NumSeats = 20},
                new Flight{FlightId=19, AirlineId=19, DepartureAirport=19, DestinationAirport=20, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 879, NumSeats = 20},
                new Flight{FlightId=20, AirlineId=20, DepartureAirport=20, DestinationAirport=1, FlightDate = new DateTime(2021,04,02,1,50,00), Price = 1356, NumSeats = 20},
            };

            List<Seat> seats = new List<Seat>()
            {
                new Seat{SeatNum = 1, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 1, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 1, isBooked = 0},
            };

            List<Booking> bookings = new List<Booking>
            {
                new Booking{BookingId = 1, PassengerId = 1, BaggageFee = 50, ServiceFee = 10, TotalFee = 993, isRoundTrip = false},
            };

            List<FlightBooking> flightBooking = new List<FlightBooking>
            {
                new FlightBooking{BookingId = 1, PassengerId = 1, SeatNum = 1, FlightId = 1},
            };

            List<Passenger> passengers = new List<Passenger>()
            {
                new Passenger{PassengerId = 1, FirstName="Dhruv", LastName= "Grover", Gender= "Male", Email = "dhruvgrover@gmail.com"},
                new Passenger{PassengerId = 2, FirstName="Pranay Sai", LastName= "Renduchintala", Gender= "Male", Email = "pranaysai@gmail.com"},
                new Passenger{PassengerId = 3, FirstName="Byeonghyeok", LastName= "Jo", Gender= "Male", Email = "byeonghyeokjo@gmail.com"},
            };

            try
            {
                context.Airports.AddRange(airports);
                context.Airlines.AddRange(airlines);
                //context.Flights.AddRange(flights);
                context.Bookings.AddRange(bookings);
                context.Passengers.AddRange(passengers);
                context.FlightBookings.AddRange(flightBooking);
                context.Passengers.AddRange(passengers);
                context.Seats.AddRange(seats);
                context.SaveChanges();
            }

            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
            }
        }
    }
}
