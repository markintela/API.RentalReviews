using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityData.Migrations
{
    /// <inheritdoc />
    public partial class UpdModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SignedById",
                table: "Signatures",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "DateSignature",
                table: "Signatures",
                newName: "LastUpdate");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Signatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "IdReview",
                table: "Signatures",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdRent",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rent",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUser",
                table: "Rent",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdate",
                table: "Rent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IdRent",
                table: "Reviews",
                column: "IdRent");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Rent_IdRent",
                table: "Reviews",
                column: "IdRent",
                principalTable: "Rent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Rent_IdRent",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_IdRent",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Signatures");

            migrationBuilder.DropColumn(
                name: "IdReview",
                table: "Signatures");

            migrationBuilder.DropColumn(
                name: "IdRent",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "LastUpdate",
                table: "Rent");

            migrationBuilder.RenameColumn(
                name: "LastUpdate",
                table: "Signatures",
                newName: "DateSignature");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Signatures",
                newName: "SignedById");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rent",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUser",
                table: "Rent",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
