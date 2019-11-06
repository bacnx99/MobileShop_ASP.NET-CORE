using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MobileShop.Migrations
{
    public partial class c : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.AddColumn<string>(
                name: "Product_CPUSpeed",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_Chipset",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_FrontCamera",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_GPU",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_OperatingSystem",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_RAM",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_ROM",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_RearCamera",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_SDCard",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_SDCardSupport",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Product_ScreenResolution",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Product_ScreenWidth",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_CPUSpeed",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_Chipset",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_FrontCamera",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_GPU",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_OperatingSystem",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_RAM",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_ROM",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_RearCamera",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_SDCard",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_SDCardSupport",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_ScreenResolution",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Product_ScreenWidth",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetail_Id = table.Column<string>(nullable: false),
                    ProductDetail_CPUSpeed = table.Column<string>(nullable: true),
                    ProductDetail_Chipset = table.Column<string>(nullable: true),
                    ProductDetail_FrontCamera = table.Column<string>(nullable: true),
                    ProductDetail_GPU = table.Column<string>(nullable: true),
                    ProductDetail_OperatingSystem = table.Column<string>(nullable: true),
                    ProductDetail_RAM = table.Column<string>(nullable: true),
                    ProductDetail_ROM = table.Column<string>(nullable: true),
                    ProductDetail_RearCamera = table.Column<string>(nullable: true),
                    ProductDetail_SDCard = table.Column<string>(nullable: true),
                    ProductDetail_SDCardSupport = table.Column<bool>(nullable: false),
                    ProductDetail_ScreenResolution = table.Column<string>(nullable: true),
                    ProductDetail_ScreenWidth = table.Column<string>(nullable: true),
                    Product_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetail_Id);
                });
        }
    }
}
