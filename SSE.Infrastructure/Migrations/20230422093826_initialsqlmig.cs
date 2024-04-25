using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSE.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialsqlmig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Origin = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    FlightCode = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Arrival = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flight");
        }
    }
}
