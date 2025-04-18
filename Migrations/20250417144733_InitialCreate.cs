using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PublicTransportNavigatorv2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "calendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Monday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Tuesday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Wednesday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Thursday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Friday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Saturday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Sunday = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "seat_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seat_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "stops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    OnRequest = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Coordinate_Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Coordinate_Longitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehicle_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicle_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    CalendarId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_lines_calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "travels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_travels_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ArrivalTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    LineId = table.Column<int>(type: "integer", nullable: false),
                    StopId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_schedules_lines_LineId",
                        column: x => x.LineId,
                        principalTable: "lines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_schedules_stops_StopId",
                        column: x => x.StopId,
                        principalTable: "stops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WheelchairAccessible = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    LineId = table.Column<int>(type: "integer", nullable: true),
                    VehicleTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicles_lines_LineId",
                        column: x => x.LineId,
                        principalTable: "lines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_vehicles_vehicle_types_VehicleTypeId",
                        column: x => x.VehicleTypeId,
                        principalTable: "vehicle_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    XOffset = table.Column<double>(type: "double precision", nullable: false),
                    YOffset = table.Column<double>(type: "double precision", nullable: false),
                    VehicleId = table.Column<int>(type: "integer", nullable: false),
                    SeatTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seats_seat_types_SeatTypeId",
                        column: x => x.SeatTypeId,
                        principalTable: "seat_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_seats_vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "seat_reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    TravelId = table.Column<int>(type: "integer", nullable: false),
                    SeatId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seat_reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_seat_reservations_seats_SeatId",
                        column: x => x.SeatId,
                        principalTable: "seats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_seat_reservations_travels_TravelId",
                        column: x => x.TravelId,
                        principalTable: "travels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lines_CalendarId",
                table: "lines",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_LineId",
                table: "schedules",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_StopId",
                table: "schedules",
                column: "StopId");

            migrationBuilder.CreateIndex(
                name: "IX_seat_reservations_SeatId",
                table: "seat_reservations",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_seat_reservations_TravelId",
                table: "seat_reservations",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_seats_SeatTypeId",
                table: "seats",
                column: "SeatTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_seats_VehicleId",
                table: "seats",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_travels_UserId",
                table: "travels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_LineId",
                table: "vehicles",
                column: "LineId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_VehicleTypeId",
                table: "vehicles",
                column: "VehicleTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropTable(
                name: "seat_reservations");

            migrationBuilder.DropTable(
                name: "stops");

            migrationBuilder.DropTable(
                name: "seats");

            migrationBuilder.DropTable(
                name: "travels");

            migrationBuilder.DropTable(
                name: "seat_types");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "lines");

            migrationBuilder.DropTable(
                name: "vehicle_types");

            migrationBuilder.DropTable(
                name: "calendars");
        }
    }
}
