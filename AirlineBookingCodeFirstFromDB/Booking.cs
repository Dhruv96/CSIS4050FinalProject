namespace AirlineBookingCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Booking")]
    public partial class Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Booking()
        {
            FlightBookings = new HashSet<FlightBooking>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PassengerId { get; set; }

        [Column(TypeName = "money")]
        public decimal BaggageFee { get; set; }

        [Column(TypeName = "money")]
        public decimal ServiceFee { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalFee { get; set; }

        public bool isRoundTrip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightBooking> FlightBookings { get; set; }
    }
}
