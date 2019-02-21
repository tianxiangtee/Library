using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class Initialmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patron_LibraryBranches_LibraryBranchId",
                table: "Patron");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patron",
                table: "Patron");

            migrationBuilder.RenameTable(
                name: "Patron",
                newName: "Patrons");

            migrationBuilder.RenameIndex(
                name: "IX_Patron_LibraryBranchId",
                table: "Patrons",
                newName: "IX_Patrons_LibraryBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patrons_LibraryBranches_LibraryBranchId",
                table: "Patrons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons");

            migrationBuilder.RenameTable(
                name: "Patrons",
                newName: "Patron");

            migrationBuilder.RenameIndex(
                name: "IX_Patrons_LibraryBranchId",
                table: "Patron",
                newName: "IX_Patron_LibraryBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patron",
                table: "Patron",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patron_LibraryBranches_LibraryBranchId",
                table: "Patron",
                column: "LibraryBranchId",
                principalTable: "LibraryBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
