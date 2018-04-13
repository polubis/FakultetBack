using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PiwoBack.Repository.Migrations
{
    public partial class elo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberFiveRate",
                table: "BeerRate");

            migrationBuilder.DropColumn(
                name: "NumberFourRate",
                table: "BeerRate");

            migrationBuilder.DropColumn(
                name: "NumberOneRate",
                table: "BeerRate");

            migrationBuilder.DropColumn(
                name: "NumberThreeRate",
                table: "BeerRate");

            migrationBuilder.DropColumn(
                name: "NumberTwoRate",
                table: "BeerRate");

            migrationBuilder.AlterColumn<int>(
                name: "Rate",
                table: "BeerRate",
                nullable: false,
                oldClrType: typeof(double));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "Rate",
                table: "BeerRate",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "NumberFiveRate",
                table: "BeerRate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberFourRate",
                table: "BeerRate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOneRate",
                table: "BeerRate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberThreeRate",
                table: "BeerRate",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberTwoRate",
                table: "BeerRate",
                nullable: false,
                defaultValue: 0);
        }
    }
}
