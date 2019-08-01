using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CinemaTicketer.Models
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
        public ICollection<Reservation> Reservations { get; set; }

        public bool SoldOut => Reservations.Sum(r => r.Seats) >= Capacity;

    }
}
