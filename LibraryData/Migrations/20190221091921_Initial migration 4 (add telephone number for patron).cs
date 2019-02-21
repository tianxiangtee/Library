using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class Initialmigration4addtelephonenumberforpatron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Patrons",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Patrons");
        }
    }
}
