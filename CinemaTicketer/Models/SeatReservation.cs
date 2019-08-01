using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketer.Models
{
    public class SeatReservation
    {
        public int SeatId { get; set; }
        public Seat Seat { get; set; }

        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        
    }
}
