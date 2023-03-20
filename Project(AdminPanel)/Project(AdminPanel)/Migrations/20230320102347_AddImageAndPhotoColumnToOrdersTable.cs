using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_AdminPanel_.Migrations
{
    public partial class AddImageAndPhotoColumnToOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Orders");
        }
    }
}
