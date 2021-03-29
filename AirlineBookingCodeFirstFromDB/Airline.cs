namespace AirlineBookingCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Airline")]
    public partial class Airline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AirlineId { get; set; }

        [Required]
        [StringLength(50)]
        public string AirlineName { get; set; }

        public override string ToString()
        {
            return AirlineName;
        }
    }
}
