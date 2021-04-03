namespace AirlineBookingCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Airport")]
    public partial class Airport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AirportId { get; set; }

        [Required]
        [StringLength(100)]
        public string AirportName { get; set; }

        public override string ToString()
        {
            return AirportName;
        }
    }
}
