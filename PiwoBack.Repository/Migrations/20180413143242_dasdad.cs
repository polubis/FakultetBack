using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PiwoBack.Repository.Migrations
{
    public partial class dasdad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerRate_Users_UserId",
                table: "BeerRate");

            migrationBuilder.DropIndex(
                name: "IX_BeerRate_UserId",
                table: "BeerRate");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "BeerRate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "BeerRate",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BeerRate_UserId",
                table: "BeerRate",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BeerRate_Users_UserId",
                table: "BeerRate",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
