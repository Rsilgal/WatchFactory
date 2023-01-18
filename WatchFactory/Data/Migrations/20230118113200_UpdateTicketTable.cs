using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WatchFactory.Data.Migrations
{
    public partial class UpdateTicketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioID",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioID",
                table: "Tickets");
        }
    }
}
