using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Consumer.Repositories.Migrations
{
    public partial class addImmobile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "properties",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    identification = table.Column<int>(nullable: false),
                    state = table.Column<double>(nullable: false),
                    city = table.Column<double>(nullable: false),
                    neighborhood = table.Column<DateTime>(nullable: false),
                    number = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_properties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "electrics",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    readDate = table.Column<DateTime>(nullable: false),
                    readNum = table.Column<int>(nullable: false),
                    kwConsumed = table.Column<double>(nullable: false),
                    value = table.Column<double>(nullable: false),
                    datePag = table.Column<DateTime>(nullable: false),
                    mediaConsumed = table.Column<double>(nullable: false),
                    residenceid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_electrics", x => x.id);
                    table.ForeignKey(
                        name: "FK_electrics_properties_residenceid",
                        column: x => x.residenceid,
                        principalTable: "properties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_electrics_residenceid",
                table: "electrics",
                column: "residenceid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "electrics");

            migrationBuilder.DropTable(
                name: "properties");
        }
    }
}
