using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    DateSet = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleClientId = table.Column<string>(nullable: false),
                    SaleVehicleId = table.Column<string>(nullable: false),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    PaidFull = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => new { x.SaleClientId, x.SaleVehicleId });
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Make = table.Column<string>(nullable: true),
                    FuelType = table.Column<string>(nullable: true),
                    Aspiration = table.Column<string>(nullable: true),
                    NumDoors = table.Column<string>(nullable: true),
                    BodyStyle = table.Column<string>(nullable: true),
                    DriveWheels = table.Column<string>(nullable: true),
                    EngineLocation = table.Column<string>(nullable: true),
                    WheelBase = table.Column<float>(nullable: false),
                    Length = table.Column<float>(nullable: false),
                    Width = table.Column<float>(nullable: false),
                    Height = table.Column<float>(nullable: false),
                    CurbWeight = table.Column<float>(nullable: false),
                    EngineType = table.Column<string>(nullable: true),
                    NumCylinders = table.Column<string>(nullable: true),
                    EngineSize = table.Column<float>(nullable: false),
                    FuelSystem = table.Column<string>(nullable: true),
                    Bore = table.Column<float>(nullable: false),
                    Stroke = table.Column<float>(nullable: false),
                    CompressionRatio = table.Column<float>(nullable: false),
                    Horsepower = table.Column<float>(nullable: false),
                    PeakRpm = table.Column<float>(nullable: false),
                    CityMpg = table.Column<float>(nullable: false),
                    HighwayMpg = table.Column<float>(nullable: false),
                    Price = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
