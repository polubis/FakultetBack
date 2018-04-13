using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PiwoBack.Repository.Migrations
{
    public partial class siemanero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerRate_Beers_BeerId",
                table: "BeerRate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BeerRate",
                table: "BeerRate");

            migrationBuilder.RenameTable(
                name: "BeerRate",
                newName: "BeerRates");

            migrationBuilder.RenameIndex(
                name: "IX_BeerRate_BeerId",
                table: "BeerRates",
                newName: "IX_BeerRates_BeerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BeerRates",
                table: "BeerRates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BeerRates_Beers_BeerId",
                table: "BeerRates",
                column: "BeerId",
                principalTable: "Beers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerRates_Beers_BeerId",
                table: "BeerRates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BeerRates",
                table: "BeerRates");

            migrationBuilder.RenameTable(
                name: "BeerRates",
                newName: "BeerRate");

            migrationBuilder.RenameIndex(
                name: "IX_BeerRates_BeerId",
                table: "BeerRate",
                newName: "IX_BeerRate_BeerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BeerRate",
                table: "BeerRate",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BeerRate_Beers_BeerId",
                table: "BeerRate",
                column: "BeerId",
                principalTable: "Beers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
