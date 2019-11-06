using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MobileShop.Migrations
{
    public partial class abcd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_Product_Id",
                        column: x => x.Product_Id,
                        principalTable: "Products",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Product_Id",
                table: "ProductDetails",
                column: "Product_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");
        }
    }
}
