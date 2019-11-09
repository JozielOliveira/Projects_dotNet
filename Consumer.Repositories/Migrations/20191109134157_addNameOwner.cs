using Microsoft.EntityFrameworkCore.Migrations;

namespace Consumer.Repositories.Migrations
{
    public partial class addNameOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nameOwner",
                table: "properties",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nameOwner",
                table: "properties");
        }
    }
}
