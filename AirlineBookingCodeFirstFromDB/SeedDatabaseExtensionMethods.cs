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

            //Airports List
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

            //Airlines List
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

            //Flights List
            List<Flight> flights = new List<Flight>()
            {
                new Flight{FlightId=1, AirlineId=1, DepartureAirport=1, DestinationAirport=2, FlightDate = new DateTime(2021,04,11,2,30,00), Price = 933, NumSeats = 20},
                new Flight{FlightId=2, AirlineId=1, DepartureAirport=1, DestinationAirport=6, FlightDate = new DateTime(2021,04,10,16,20,00), Price = 1033, NumSeats = 20},
                new Flight{FlightId=3, AirlineId=1, DepartureAirport=1, DestinationAirport=7, FlightDate = new DateTime(2021,04,15,17,22,00), Price = 1733, NumSeats = 20},

                new Flight{FlightId=4, AirlineId=2, DepartureAirport=2, DestinationAirport=5, FlightDate = new DateTime(2021,04,14,4,20,00), Price = 1315, NumSeats = 20},
                new Flight{FlightId=5, AirlineId=2, DepartureAirport=2, DestinationAirport=4, FlightDate = new DateTime(2021,04,12,8,30,00), Price = 1225, NumSeats = 20},
                new Flight{FlightId=6, AirlineId=2, DepartureAirport=2, DestinationAirport=8, FlightDate = new DateTime(2021,04,10,15,50,00), Price = 1435, NumSeats = 20},

                new Flight{FlightId=7, AirlineId=3, DepartureAirport=3, DestinationAirport=7, FlightDate = new DateTime(2021,04,13,7,10,00), Price = 1207, NumSeats = 20},
                new Flight{FlightId=8, AirlineId=3, DepartureAirport=3, DestinationAirport=9, FlightDate = new DateTime(2021,04,14,8,30,00), Price = 1147, NumSeats = 20},
                new Flight{FlightId=9, AirlineId=3, DepartureAirport=3, DestinationAirport=10, FlightDate = new DateTime(2021,04,17,3,20,00), Price = 1183, NumSeats = 20},

                new Flight{FlightId=10, AirlineId=4, DepartureAirport=4, DestinationAirport=1, FlightDate = new DateTime(2021,04,15,1,50,00), Price = 1156, NumSeats = 20},
                new Flight{FlightId=11, AirlineId=4, DepartureAirport=4, DestinationAirport=2, FlightDate = new DateTime(2021,04,12,14,20,00), Price = 1344, NumSeats = 20},
                new Flight{FlightId=12, AirlineId=4, DepartureAirport=4, DestinationAirport=6, FlightDate = new DateTime(2021,04,19,17,40,00), Price = 1016, NumSeats = 20},

                new Flight{FlightId=13, AirlineId=5, DepartureAirport=5, DestinationAirport=3, FlightDate = new DateTime(2021,04,15,2,10,00), Price = 1059, NumSeats = 20},
                new Flight{FlightId=14, AirlineId=5, DepartureAirport=5, DestinationAirport=7, FlightDate = new DateTime(2021,04,16,5,30,00), Price = 959, NumSeats = 20},
                new Flight{FlightId=15, AirlineId=5, DepartureAirport=5, DestinationAirport=8, FlightDate = new DateTime(2021,04,06,7,22,00), Price = 852, NumSeats = 20},

                new Flight{FlightId=16, AirlineId=6, DepartureAirport=6, DestinationAirport=2, FlightDate = new DateTime(2021,04,20,7,20,00), Price = 977, NumSeats = 20},
                new Flight{FlightId=17, AirlineId=6, DepartureAirport=6, DestinationAirport=9, FlightDate = new DateTime(2021,04,11,5,40,00), Price = 1037, NumSeats = 20},
                new Flight{FlightId=18, AirlineId=6, DepartureAirport=6, DestinationAirport=10, FlightDate = new DateTime(2021,04,13,19,20,00), Price = 1247, NumSeats = 20},

                new Flight{FlightId=19, AirlineId=7, DepartureAirport=7, DestinationAirport=6, FlightDate = new DateTime(2021,04,10,10,40,00), Price = 767, NumSeats = 20},
                new Flight{FlightId=20, AirlineId=7, DepartureAirport=7, DestinationAirport=3, FlightDate = new DateTime(2021,04,11,09,15,00), Price = 955, NumSeats = 20},
                new Flight{FlightId=21, AirlineId=7, DepartureAirport=7, DestinationAirport=5, FlightDate = new DateTime(2021,04,12,06,33,00), Price = 878, NumSeats = 20},

                new Flight{FlightId=22, AirlineId=8, DepartureAirport=8, DestinationAirport=9, FlightDate = new DateTime(2021,04,21,11,20,00), Price = 1234, NumSeats = 20},
                new Flight{FlightId=23, AirlineId=8, DepartureAirport=8, DestinationAirport=2, FlightDate = new DateTime(2021,04,15,21,10,00), Price = 1314, NumSeats = 20},
                new Flight{FlightId=24, AirlineId=8, DepartureAirport=8, DestinationAirport=4, FlightDate = new DateTime(2021,04,20,16,50,00), Price = 1421, NumSeats = 20},

                new Flight{FlightId=25, AirlineId=9, DepartureAirport=9, DestinationAirport=10, FlightDate = new DateTime(2021,04,18,15,45,00), Price = 1365, NumSeats = 20},
                new Flight{FlightId=26, AirlineId=9, DepartureAirport=9, DestinationAirport=1, FlightDate = new DateTime(2021,04,17,12,45,00), Price = 1135, NumSeats = 20},
                new Flight{FlightId=27, AirlineId=9, DepartureAirport=9, DestinationAirport=2, FlightDate = new DateTime(2021,04,24,14,15,00), Price = 1245, NumSeats = 20},

                new Flight{FlightId=28, AirlineId=10, DepartureAirport=10, DestinationAirport=11, FlightDate = new DateTime(2021,04,16,18,50,00), Price = 1469, NumSeats = 20},
                new Flight{FlightId=29, AirlineId=10, DepartureAirport=10, DestinationAirport=17, FlightDate = new DateTime(2021,04,22,1,10,00), Price = 1239, NumSeats = 20},
                new Flight{FlightId=30, AirlineId=10, DepartureAirport=10, DestinationAirport=18, FlightDate = new DateTime(2021,04,23,2,10,00), Price = 1390, NumSeats = 20},

                new Flight{FlightId=31, AirlineId=11, DepartureAirport=11, DestinationAirport=12, FlightDate = new DateTime(2021,04,13,23,20,00), Price = 1132, NumSeats = 20},
                new Flight{FlightId=32, AirlineId=11, DepartureAirport=11, DestinationAirport=16, FlightDate = new DateTime(2021,04,11,20,40,00), Price = 1152, NumSeats = 20},
                new Flight{FlightId=33, AirlineId=11, DepartureAirport=11, DestinationAirport=15, FlightDate = new DateTime(2021,04,10,18,30,00), Price = 1112, NumSeats = 20},

                new Flight{FlightId=34, AirlineId=12, DepartureAirport=12, DestinationAirport=13, FlightDate = new DateTime(2021,04,14,22,25,00), Price = 1274, NumSeats = 20},
                new Flight{FlightId=35, AirlineId=12, DepartureAirport=12, DestinationAirport=14, FlightDate = new DateTime(2021,04,18,00,15,00), Price = 1572, NumSeats = 20},
                new Flight{FlightId=36, AirlineId=12, DepartureAirport=12, DestinationAirport=19, FlightDate = new DateTime(2021,04,16,11,35,00), Price = 1138, NumSeats = 20},

                new Flight{FlightId=37, AirlineId=13, DepartureAirport=13, DestinationAirport=14, FlightDate = new DateTime(2021,04,10,1,15,00), Price = 1089, NumSeats = 20},
                new Flight{FlightId=38, AirlineId=13, DepartureAirport=13, DestinationAirport=12, FlightDate = new DateTime(2021,04,12,15,35,00), Price = 859, NumSeats = 20},
                new Flight{FlightId=39, AirlineId=13, DepartureAirport=13, DestinationAirport=20, FlightDate = new DateTime(2021,04,14,18,45,00), Price = 845, NumSeats = 20},

                new Flight{FlightId=40, AirlineId=14, DepartureAirport=14, DestinationAirport=15, FlightDate = new DateTime(2021,04,12,21,30,00), Price = 1455, NumSeats = 20},
                new Flight{FlightId=41, AirlineId=14, DepartureAirport=14, DestinationAirport=16, FlightDate = new DateTime(2021,04,13,22,40,00), Price = 1253, NumSeats = 20},
                new Flight{FlightId=42, AirlineId=14, DepartureAirport=14, DestinationAirport=17, FlightDate = new DateTime(2021,04,16,2,50,00), Price = 1145, NumSeats = 20},

                new Flight{FlightId=43, AirlineId=15, DepartureAirport=15, DestinationAirport=16, FlightDate = new DateTime(2021,04,16,4,40,00), Price = 989, NumSeats = 20},
                new Flight{FlightId=44, AirlineId=15, DepartureAirport=15, DestinationAirport=14, FlightDate = new DateTime(2021,04,11,14,20,00), Price = 1039, NumSeats = 20},
                new Flight{FlightId=45, AirlineId=15, DepartureAirport=15, DestinationAirport=11, FlightDate = new DateTime(2021,04,19,21,40,00), Price = 1057, NumSeats = 20},

                new Flight{FlightId=46, AirlineId=16, DepartureAirport=16, DestinationAirport=17, FlightDate = new DateTime(2021,04,19,20,10,00), Price = 1170, NumSeats = 20},
                new Flight{FlightId=47, AirlineId=16, DepartureAirport=16, DestinationAirport=12, FlightDate = new DateTime(2021,04,15,19,20,00), Price = 1120, NumSeats = 20},
                new Flight{FlightId=48, AirlineId=16, DepartureAirport=16, DestinationAirport=18, FlightDate = new DateTime(2021,04,18,17,50,00), Price = 1150, NumSeats = 20},

                new Flight{FlightId=49, AirlineId=17, DepartureAirport=17, DestinationAirport=13, FlightDate = new DateTime(2021,04,17,17,40,00), Price = 1120, NumSeats = 20},
                new Flight{FlightId=50, AirlineId=17, DepartureAirport=17, DestinationAirport=14, FlightDate = new DateTime(2021,04,18,17,40,00), Price = 1240, NumSeats = 20},
                new Flight{FlightId=51, AirlineId=17, DepartureAirport=17, DestinationAirport=19, FlightDate = new DateTime(2021,04,20,17,40,00), Price = 1180, NumSeats = 20},

                new Flight{FlightId=52, AirlineId=18, DepartureAirport=18, DestinationAirport=19, FlightDate = new DateTime(2021,04,16,14,10,00), Price = 930, NumSeats = 20},
                new Flight{FlightId=53, AirlineId=18, DepartureAirport=18, DestinationAirport=20, FlightDate = new DateTime(2021,04,13,15,10,00), Price = 890, NumSeats = 20},
                new Flight{FlightId=54, AirlineId=18, DepartureAirport=18, DestinationAirport=14, FlightDate = new DateTime(2021,04,11,18,10,00), Price = 870, NumSeats = 20},

                new Flight{FlightId=55, AirlineId=19, DepartureAirport=19, DestinationAirport=16, FlightDate = new DateTime(2021,04,21,15,15,00), Price = 879, NumSeats = 20},
                new Flight{FlightId=56, AirlineId=19, DepartureAirport=19, DestinationAirport=17, FlightDate = new DateTime(2021,04,20,14,35,00), Price = 849, NumSeats = 20},
                new Flight{FlightId=57, AirlineId=19, DepartureAirport=19, DestinationAirport=12, FlightDate = new DateTime(2021,04,18,12,55,00), Price = 979, NumSeats = 20},

                new Flight{FlightId=58, AirlineId=20, DepartureAirport=20, DestinationAirport=11, FlightDate = new DateTime(2021,04,14,05,20,00), Price = 1356, NumSeats = 20},
                new Flight{FlightId=59, AirlineId=20, DepartureAirport=20, DestinationAirport=19, FlightDate = new DateTime(2021,04,16,07,30,00), Price = 1236, NumSeats = 20},
                new Flight{FlightId=60, AirlineId=20, DepartureAirport=20, DestinationAirport=15, FlightDate = new DateTime(2021,04,19,06,40,00), Price = 1116, NumSeats = 20}
            };

            //Seats in each flight
            List<Seat> seats = new List<Seat>()
            {
                //Flight ID = 1
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

                //Flight ID = 2
                new Seat{SeatNum = 1, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 2, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 2, isBooked = 0},

                //Flight ID = 3
                new Seat{SeatNum = 1, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 3, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 3, isBooked = 0},

                //Flight ID = 4
                new Seat{SeatNum = 1, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 4, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 4, isBooked = 0},

                //Flight ID = 5
                new Seat{SeatNum = 1, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 5, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 5, isBooked = 0},

                //Flight ID = 6
                new Seat{SeatNum = 1, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 6, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 6, isBooked = 0},

                //Flight ID = 7
                new Seat{SeatNum = 1, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 7, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 7, isBooked = 0},

                //Flight ID = 8
                new Seat{SeatNum = 1, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 8, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 8, isBooked = 0},

                //Flight ID = 9
                new Seat{SeatNum = 1, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 9, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 9, isBooked = 0},

                //Flight ID = 10
                new Seat{SeatNum = 1, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 10, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 10, isBooked = 0},

                //Flight ID = 11
                new Seat{SeatNum = 1, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 11, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 11, isBooked = 0},

                //Flight ID = 12
                new Seat{SeatNum = 1, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 12, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 12, isBooked = 0},

                //Flight ID = 13
                new Seat{SeatNum = 1, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 13, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 13, isBooked = 0},

                //Flight ID = 14
                new Seat{SeatNum = 1, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 14, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 14, isBooked = 0},

                //Flight ID = 15
                new Seat{SeatNum = 1, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 15, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 15, isBooked = 0},

                //Flight ID = 16
                new Seat{SeatNum = 1, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 16, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 16, isBooked = 0},

                //Flight ID = 17
                new Seat{SeatNum = 1, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 17, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 17, isBooked = 0},

                //Flight ID = 18
                new Seat{SeatNum = 1, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 18, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 18, isBooked = 0},

                //Flight ID = 19
                new Seat{SeatNum = 1, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 19, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 19, isBooked = 0},

                //Flight ID = 20
                new Seat{SeatNum = 1, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 2, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 3, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 4, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 5, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 6, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 7, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 8, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 9, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 10, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 11, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 12, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 13, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 14, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 15, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 16, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 17, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 18, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 19, FlightId = 20, isBooked = 0},
                new Seat{SeatNum = 20, FlightId = 20, isBooked = 0},
            };

            //Bookings Sample List
            List<Booking> bookings = new List<Booking>
            {
                new Booking{BookingId = 1, PassengerId = 1, BaggageFee = 50, ServiceFee = 10, TotalFee = 993},
            };

            
            List<FlightBooking> flightBooking = new List<FlightBooking>
            {
                new FlightBooking{BookingId = 1, PassengerId = 1, SeatNum = 1, FlightId = 1},
            };

            //Sample passengers list
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
                context.Flights.AddRange(flights);
                context.SaveChanges();
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
