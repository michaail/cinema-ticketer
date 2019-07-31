using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaTicketer.Shared.Models
{
    public class Seat
    {
        [Key]
        public Guid Id { get; set; }

        public int Row { get; set; }
        public int Column { get; set; }

        public ICollection<SeatReservation> SeatReservations { get; set; }
        public ICollection<Screening> Screenings { get; set; }

      
    }
}
