using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hermes.Data.Migrations
{
    public partial class UpdateTables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IeSM_USER_ID",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IeSM_SUB_CATEGORY_ID",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IeSM_CONTACT_ID",
                table: "Contacts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IeSM_CALL_STATUS_ID",
                table: "CallStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IeSM_SUB_CATEGORY_ID",
                table: "CallPriorities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IeSM_CALL_CATEGORY_ID",
                table: "CallCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IeSM_CALL_NO",
                table: "Calls",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IeSM_USER_ID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IeSM_SUB_CATEGORY_ID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IeSM_CONTACT_ID",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "IeSM_CALL_STATUS_ID",
                table: "CallStatus");

            migrationBuilder.DropColumn(
                name: "IeSM_SUB_CATEGORY_ID",
                table: "CallPriorities");

            migrationBuilder.DropColumn(
                name: "IeSM_CALL_CATEGORY_ID",
                table: "CallCategories");

            migrationBuilder.DropColumn(
                name: "IeSM_CALL_NO",
                table: "Calls");
        }
    }
}
