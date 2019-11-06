using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MobileShop.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_Product_Id",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_Product_Id",
                table: "ProductDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_Product_Id",
                table: "ProductDetails",
                column: "Product_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_Product_Id",
                table: "ProductDetails",
                column: "Product_Id",
                principalTable: "Products",
                principalColumn: "Product_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
