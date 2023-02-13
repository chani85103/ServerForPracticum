using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clients.Context.Migrations
{
    public partial class tuesday3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyHmo",
                table: "Clients",
                newName: "MyImpression");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyImpression",
                table: "Clients",
                newName: "MyHmo");
        }
    }
}
