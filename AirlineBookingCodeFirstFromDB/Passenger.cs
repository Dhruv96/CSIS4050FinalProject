namespace AirlineBookingCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Passenger")]
    public partial class Passenger
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PassengerId { get; set; }

        [Required]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        public string LastName { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        [StringLength(10)]
        public string Email { get; set; }
    }
}
