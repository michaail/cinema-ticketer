using CinemaTicketer.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaTicketer.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }

        //public int MovieId { get; set; }
        public Screening Screening { get; set; }

        public int Seats { get; set; }
        public ICollection<SeatReservation> SeatReservations { get; set; }
        
    }
}
