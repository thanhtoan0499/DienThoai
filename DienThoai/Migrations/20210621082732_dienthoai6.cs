﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DienThoai.Migrations
{
    public partial class dienthoai6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "namehinh",
                table: "SanPham",
                newName: "ImageName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "SanPham",
                newName: "namehinh");
        }
    }
}