using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaTicketer.Shared.Models
{
    [NotMapped]
    public class Seat
    {
        [NotMapped]
        public int Row { get; set; }
        [NotMapped]
        public int Column { get; set; }

    }
}
