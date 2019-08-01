using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaTicketer.Areas.Identity.Data;
using CinemaTicketer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaTicketer.Data
{
    public class CinemaTicketerContext : IdentityDbContext<User>
    {
        public CinemaTicketerContext(DbContextOptions<CinemaTicketerContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SeatReservation>()
                .HasKey(t => new { t.ReservationId, t.SeatId });

            
        }
    }
}
