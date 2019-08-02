using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CinemaTicketer.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter movie name")]
        public string Name { get; set; }
        // Duration in minutes
        [Required(ErrorMessage = "Enter movie duration")]
        public int Duration { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }

        public string PosterUrl { get; set; }
        public DateTimeOffset PremiereDate { get; set; }
        public bool NotYetPremiered => PremiereDate > DateTimeOffset.Now;

        // Week old is new
        public bool IsNew => !NotYetPremiered && (DateTimeOffset.Now - PremiereDate).TotalDays <= 7;
        //public ICollection<Reservation> Reservations { get; set; }
        //public ICollection<Screening> Screenings { get; set; }
        
    }
}
