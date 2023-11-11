using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityData.Migrations
{
    /// <inheritdoc />
    public partial class UpdModels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rent_Locations_IdLocation",
                table: "Rent");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Rent_IdRent",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Signatures_IdSignature",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_IdSignature",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rent",
                table: "Rent");

            migrationBuilder.DropColumn(
                name: "IdSignature",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Rent",
                newName: "Rents");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Signatures",
                newName: "SignedById");

            migrationBuilder.RenameIndex(
                name: "IX_Rent_IdLocation",
                table: "Rents",
                newName: "IX_Rents_IdLocation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Signatures",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Signatures",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Reviews",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Reviews",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AddressDetails",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Rents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Rents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rents",
                table: "Rents",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Signatures_IdReview",
                table: "Signatures",
                column: "IdReview");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Locations_IdLocation",
                table: "Rents",
                column: "IdLocation",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Users_Id",
                table: "Rents",
                column: "Id",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Rents_IdRent",
                table: "Reviews",
                column: "IdRent",
                principalTable: "Rents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Signatures_Reviews_IdReview",
                table: "Signatures",
                column: "IdReview",
                principalTable: "Reviews",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Locations_IdLocation",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Users_Id",
                table: "Rents");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Rents_IdRent",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Signatures_Reviews_IdReview",
                table: "Signatures");

            migrationBuilder.DropIndex(
                name: "IX_Signatures_IdReview",
                table: "Signatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rents",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Signatures");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "AddressDetails",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Rents");

            migrationBuilder.RenameTable(
                name: "Rents",
                newName: "Rent");

            migrationBuilder.RenameColumn(
                name: "SignedById",
                table: "Signatures",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Rents_IdLocation",
                table: "Rent",
                newName: "IX_Rent_IdLocation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Signatures",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdSignature",
                table: "Reviews",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdate",
                table: "Rent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rent",
                table: "Rent",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_IdSignature",
                table: "Reviews",
                column: "IdSignature");

            migrationBuilder.AddForeignKey(
                name: "FK_Rent_Locations_IdLocation",
                table: "Rent",
                column: "IdLocation",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Rent_IdRent",
                table: "Reviews",
                column: "IdRent",
                principalTable: "Rent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Signatures_IdSignature",
                table: "Reviews",
                column: "IdSignature",
                principalTable: "Signatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
