using Microsoft.EntityFrameworkCore.Migrations;

namespace Juan.Migrations
{
    public partial class createCardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Percent",
                table: "Discounts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Percent",
                table: "Discounts");
        }
    }
}
