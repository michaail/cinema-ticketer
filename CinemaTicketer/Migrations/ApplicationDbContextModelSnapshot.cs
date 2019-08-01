﻿// <auto-generated />
using System;
using CinemaTicketer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinemaTicketer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinemaTicketer.Shared.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Rating");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ScreeningId");

                    b.Property<int>("Seats");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ScreeningId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Date");

                    b.Property<int?>("MovieId");

                    b.Property<Guid?>("SeatId");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("SeatId");

                    b.ToTable("Screenings");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Column");

                    b.Property<int>("Row");

                    b.HasKey("Id");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.SeatReservation", b =>
                {
                    b.Property<int>("ReservationId");

                    b.Property<int>("SeatId");

                    b.Property<Guid?>("SeatId1");

                    b.HasKey("ReservationId", "SeatId");

                    b.HasIndex("SeatId1");

                    b.ToTable("SeatReservation");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.Reservation", b =>
                {
                    b.HasOne("CinemaTicketer.Shared.Models.Screening", "Screening")
                        .WithMany("Reservations")
                        .HasForeignKey("ScreeningId");

                    b.HasOne("CinemaTicketer.Shared.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.Screening", b =>
                {
                    b.HasOne("CinemaTicketer.Shared.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.HasOne("CinemaTicketer.Shared.Models.Seat")
                        .WithMany("Screenings")
                        .HasForeignKey("SeatId");
                });

            modelBuilder.Entity("CinemaTicketer.Shared.Models.SeatReservation", b =>
                {
                    b.HasOne("CinemaTicketer.Shared.Models.Reservation", "Reservation")
                        .WithMany("SeatReservations")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinemaTicketer.Shared.Models.Seat", "Seat")
                        .WithMany("SeatReservations")
                        .HasForeignKey("SeatId1");
                });
#pragma warning restore 612, 618
        }
    }
}