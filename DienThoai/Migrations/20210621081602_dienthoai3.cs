using Microsoft.EntityFrameworkCore.Migrations;

namespace DienThoai.Migrations
{
    public partial class dienthoai3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "SanPham",
                type: "nvarchar(100)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "SanPham");
        }
    }
}
