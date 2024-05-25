using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsuranceCustomerManager.Console.Migrations
{
    /// <inheritdoc />
    public partial class RenamePlaceToCityColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlaceOfBirth",
                table: "Customers",
                newName: "CityOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityOfBirth",
                table: "Customers",
                newName: "PlaceOfBirth");
        }
    }
}
