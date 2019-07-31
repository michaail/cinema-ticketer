using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaTicketer.Migrations
{
    public partial class manytomanyseats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Reservations_ReservationId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Screenings_ScreeningId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ReservationId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_ScreeningId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "ScreeningId",
                table: "Seats");

            migrationBuilder.AddColumn<Guid>(
                name: "SeatId",
                table: "Screenings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Seats",
                table: "Reservations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SeatReservation",
                columns: table => new
                {
                    SeatId = table.Column<int>(nullable: false),
                    ReservationId = table.Column<int>(nullable: false),
                    SeatId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatReservation", x => new { x.ReservationId, x.SeatId });
                    table.ForeignKey(
                        name: "FK_SeatReservation_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatReservation_Seats_SeatId1",
                        column: x => x.SeatId1,
                        principalTable: "Seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_SeatId",
                table: "Screenings",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatReservation_SeatId1",
                table: "SeatReservation",
                column: "SeatId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Screenings_Seats_SeatId",
                table: "Screenings",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Screenings_Seats_SeatId",
                table: "Screenings");

            migrationBuilder.DropTable(
                name: "SeatReservation");

            migrationBuilder.DropIndex(
                name: "IX_Screenings_SeatId",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "Screenings");

            migrationBuilder.DropColumn(
                name: "Seats",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Seats",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScreeningId",
                table: "Seats",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ReservationId",
                table: "Seats",
                column: "ReservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_ScreeningId",
                table: "Seats",
                column: "ScreeningId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Reservations_ReservationId",
                table: "Seats",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Screenings_ScreeningId",
                table: "Seats",
                column: "ScreeningId",
                principalTable: "Screenings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
