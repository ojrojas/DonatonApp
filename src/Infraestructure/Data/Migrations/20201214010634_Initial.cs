using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestructure.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    MiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StateMaterials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDonation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDonation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeIdentifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeIdentifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonationMoneys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<decimal>(type: "TEXT", nullable: false),
                    DateDonation = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BankId = table.Column<Guid>(type: "TEXT", nullable: false),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeDonationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeIdentificationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Identification = table.Column<string>(type: "TEXT", nullable: true),
                    Donor = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationMoneys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationMoneys_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationMoneys_TypeDonation_TypeDonationId",
                        column: x => x.TypeDonationId,
                        principalTable: "TypeDonation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationMoneys_TypeIdentifications_TypeIdentificationId",
                        column: x => x.TypeIdentificationId,
                        principalTable: "TypeIdentifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationNonPerishables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<double>(type: "REAL", nullable: false),
                    StateMaterialId = table.Column<Guid>(type: "TEXT", nullable: false),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeDonationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeIdentificationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Identification = table.Column<string>(type: "TEXT", nullable: true),
                    Donor = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeliveryName = table.Column<string>(type: "TEXT", nullable: true),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationNonPerishables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationNonPerishables_StateMaterials_StateMaterialId",
                        column: x => x.StateMaterialId,
                        principalTable: "StateMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationNonPerishables_TypeDonation_TypeDonationId",
                        column: x => x.TypeDonationId,
                        principalTable: "TypeDonation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationNonPerishables_TypeIdentifications_TypeIdentificationId",
                        column: x => x.TypeIdentificationId,
                        principalTable: "TypeIdentifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationPerishables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitMeasurement = table.Column<string>(type: "TEXT", nullable: true),
                    DateExpiration = table.Column<DateTime>(type: "TEXT", nullable: false),
                    State = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeDonationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeIdentificationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Identification = table.Column<string>(type: "TEXT", nullable: true),
                    Donor = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DeliveryName = table.Column<string>(type: "TEXT", nullable: true),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationPerishables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationPerishables_TypeDonation_TypeDonationId",
                        column: x => x.TypeDonationId,
                        principalTable: "TypeDonation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationPerishables_TypeIdentifications_TypeIdentificationId",
                        column: x => x.TypeIdentificationId,
                        principalTable: "TypeIdentifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonationMoneys_BankId",
                table: "DonationMoneys",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMoneys_TypeDonationId",
                table: "DonationMoneys",
                column: "TypeDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMoneys_TypeIdentificationId",
                table: "DonationMoneys",
                column: "TypeIdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationNonPerishables_StateMaterialId",
                table: "DonationNonPerishables",
                column: "StateMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationNonPerishables_TypeDonationId",
                table: "DonationNonPerishables",
                column: "TypeDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationNonPerishables_TypeIdentificationId",
                table: "DonationNonPerishables",
                column: "TypeIdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationPerishables_TypeDonationId",
                table: "DonationPerishables",
                column: "TypeDonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationPerishables_TypeIdentificationId",
                table: "DonationPerishables",
                column: "TypeIdentificationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "DonationMoneys");

            migrationBuilder.DropTable(
                name: "DonationNonPerishables");

            migrationBuilder.DropTable(
                name: "DonationPerishables");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "StateMaterials");

            migrationBuilder.DropTable(
                name: "TypeDonation");

            migrationBuilder.DropTable(
                name: "TypeIdentifications");
        }
    }
}
