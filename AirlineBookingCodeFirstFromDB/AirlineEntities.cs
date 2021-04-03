using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AirlineBookingCodeFirstFromDB
{
    public partial class AirlineEntities : DbContext
    {
        public AirlineEntities()
            : base("name=AirlinesDBConnection")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightBooking> FlightBookings { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airline>()
                .Property(e => e.AirlineName)
                .IsFixedLength();

            modelBuilder.Entity<Airport>()
                .Property(e => e.AirportName)
                .IsFixedLength();

            modelBuilder.Entity<Booking>()
                .Property(e => e.BaggageFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Booking>()
                .Property(e => e.ServiceFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Booking>()
                .Property(e => e.TotalFee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Booking>()
                .HasMany(e => e.FlightBookings)
                .WithRequired(e => e.Booking)
                .HasForeignKey(e => new { e.BookingId, e.PassengerId })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Flight>()
                .HasMany(e => e.FlightBookings)
                .WithRequired(e => e.Flight)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Passenger>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.Gender)
                .IsFixedLength();

            modelBuilder.Entity<Passenger>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<Seat>()
                .HasMany(e => e.FlightBookings)
                .WithRequired(e => e.Seat)
                .HasForeignKey(e => new { e.SeatNum, e.FlightId })
                .WillCascadeOnDelete(false);
        }
    }
}
