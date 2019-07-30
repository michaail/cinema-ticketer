using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaTicketer.Shared.Models
{
    public class Screening
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public DateTimeOffset Date { get; set; }

        public int Rows => Hall.Rows;
        public int Collumns => Hall.Collumns;
        public int Capacity => Rows * Collumns;
        public ICollection<Seat> ReservedSeats { get; set; }

        public bool SoldOut => ReservedSeats.Count >= Capacity;

    }
}
