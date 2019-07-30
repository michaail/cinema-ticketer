using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaTicketer.Shared.Models
{
    class Screening
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public DateTimeOffset Date { get; set; }

        public ICollection<Seat> ReservedSeats { get; set; }

    }
}
