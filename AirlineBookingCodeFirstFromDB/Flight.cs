namespace AirlineBookingCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Flight")]
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            FlightBookings = new HashSet<FlightBooking>();
            Seats = new HashSet<Seat>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FlightId { get; set; }

        public int AirlineId { get; set; }

        public int DepartureAirport { get; set; }

        public int DestinationAirport { get; set; }

        public DateTime FlightDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int NumSeats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightBooking> FlightBookings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
