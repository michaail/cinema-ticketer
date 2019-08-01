using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaTicketer.Migrations
{
    public partial class expandedMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cast",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PosterUrl",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cast",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PosterUrl",
                table: "Movies");
        }
    }
}
