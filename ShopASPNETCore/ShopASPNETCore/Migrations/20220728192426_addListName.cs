using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopASPNETCore.Migrations
{
    public partial class addListName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ListName",
                table: "TaskList",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListName",
                table: "TaskList");
        }
    }
}
