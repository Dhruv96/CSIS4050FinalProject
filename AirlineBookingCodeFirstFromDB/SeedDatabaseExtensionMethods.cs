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
                new Airport{AirportId = 1, AirportName = "Vancouver International Airport"},
                new Airport{AirportId = 2, AirportName = "Indira Gandhi International Airport"},
                new Airport{AirportId = 3, AirportName = "Pearson International Airport"}
            };

            List<Airline> airlines = new List<Airline>()
            {
                new Airline{AirlineId=1, AirlineName = "Air Canada"},
                new Airline{AirlineId=2, AirlineName = "Air India"},
                new Airline{AirlineId=3, AirlineName = "Lufthansa"}
            };

            try
            {
                context.Airports.AddRange(airports);
                context.Airlines.AddRange(airlines);
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
