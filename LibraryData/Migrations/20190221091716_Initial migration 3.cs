using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class Initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.RenameColumn(
                name: "LibraryBranchId",
                table: "Patrons",
                newName: "HomeLibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_HomeLibraryBranchId");

            migrationBuilder.AddColumn<int>(
                name: "LibraryCardId",
                table: "Patrons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons",
                column: "HomeLibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons",
                column: "LibraryCardId",
                principalTable: "LibraryCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_HomeLibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryCards_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropIndex(
                name: "IX_Patrons_LibraryCardId",
                table: "Patrons");

            migrationBuilder.DropColumn(
                name: "LibraryCardId",
                table: "Patrons");

            migrationBuilder.RenameColumn(
                name: "HomeLibraryBranchId",
                table: "Patrons",
                newName: "LibraryBranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_HomeLibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
