using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaTicketer.Shared.Models
{
    class Reservation
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        //public int MovieId { get; set; }
        public int ScreeningId { get; set; }

        public ICollection<Seat> ReservedSeats { get; set; }
    }
}
