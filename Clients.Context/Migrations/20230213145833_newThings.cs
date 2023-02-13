using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clients.Context.Migrations
{
    public partial class newThings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsMale",
                table: "Clients",
                newName: "ToAdvertise");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToAdvertise",
                table: "Clients",
                newName: "IsMale");
        }
    }
}
