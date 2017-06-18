using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hermes.Data.Migrations
{
    public partial class updateCallTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calls_Contacts_ContactId",
                table: "Calls");

            migrationBuilder.DropIndex(
                name: "IX_Calls_ContactId",
                table: "Calls");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Calls");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Calls",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Calls");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Calls",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calls_ContactId",
                table: "Calls",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calls_Contacts_ContactId",
                table: "Calls",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
