using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Data.Migrations
{
    public partial class quicktypedonations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonationMoneys_TypeDonation_TypeDonationId",
                table: "DonationMoneys");

            migrationBuilder.DropForeignKey(
                name: "FK_DonationNonPerishables_TypeDonation_TypeDonationId",
                table: "DonationNonPerishables");

            migrationBuilder.DropForeignKey(
                name: "FK_DonationPerishables_TypeDonation_TypeDonationId",
                table: "DonationPerishables");

            migrationBuilder.DropIndex(
                name: "IX_DonationPerishables_TypeDonationId",
                table: "DonationPerishables");

            migrationBuilder.DropIndex(
                name: "IX_DonationNonPerishables_TypeDonationId",
                table: "DonationNonPerishables");

            migrationBuilder.DropIndex(
                name: "IX_DonationMoneys_TypeDonationId",
                table: "DonationMoneys");

            migrationBuilder.DropColumn(
                name: "TypeDonationId",
                table: "DonationPerishables");

            migrationBuilder.DropColumn(
                name: "TypeDonationId",
                table: "DonationNonPerishables");

            migrationBuilder.DropColumn(
                name: "TypeDonationId",
                table: "DonationMoneys");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TypeDonationId",
                table: "DonationPerishables",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeDonationId",
                table: "DonationNonPerishables",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TypeDonationId",
                table: "DonationMoneys",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_DonationPerishables_TypeDonationId",
                table: "DonationPerishables",
                column: "TypeDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationNonPerishables_TypeDonationId",
                table: "DonationNonPerishables",
                column: "TypeDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMoneys_TypeDonationId",
                table: "DonationMoneys",
                column: "TypeDonationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonationMoneys_TypeDonation_TypeDonationId",
                table: "DonationMoneys",
                column: "TypeDonationId",
                principalTable: "TypeDonation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonationNonPerishables_TypeDonation_TypeDonationId",
                table: "DonationNonPerishables",
                column: "TypeDonationId",
                principalTable: "TypeDonation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonationPerishables_TypeDonation_TypeDonationId",
                table: "DonationPerishables",
                column: "TypeDonationId",
                principalTable: "TypeDonation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
