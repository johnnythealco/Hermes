using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hermes.Data.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CallPriorities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallPriorities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CallStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    Address3 = table.Column<string>(nullable: true),
                    Address4 = table.Column<string>(nullable: true),
                    Address5 = table.Column<string>(nullable: true),
                    FaxNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserEmail = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactName = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FaxNo = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssignedToId = table.Column<int>(nullable: true),
                    CallCategoryId = table.Column<int>(nullable: true),
                    CallClosed = table.Column<bool>(nullable: false),
                    CallDescription = table.Column<string>(nullable: true),
                    CallDuration = table.Column<int>(nullable: false),
                    ClosedById = table.Column<int>(nullable: true),
                    ContactId = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    DateClosed = table.Column<DateTime>(nullable: false),
                    DateLogged = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    LoggedById = table.Column<int>(nullable: true),
                    PriorityId = table.Column<int>(nullable: true),
                    Problem = table.Column<string>(nullable: true),
                    Resolved = table.Column<bool>(nullable: false),
                    Solution = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    TotalDuration = table.Column<int>(nullable: false),
                    UserModifiedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calls_Users_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_CallCategories_CallCategoryId",
                        column: x => x.CallCategoryId,
                        principalTable: "CallCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_Users_ClosedById",
                        column: x => x.ClosedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_Users_LoggedById",
                        column: x => x.LoggedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_CallPriorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "CallPriorities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_CallStatus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "CallStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calls_Users_UserModifiedId",
                        column: x => x.UserModifiedId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calls_AssignedToId",
                table: "Calls",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_CallCategoryId",
                table: "Calls",
                column: "CallCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_ClosedById",
                table: "Calls",
                column: "ClosedById");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_ContactId",
                table: "Calls",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_CustomerId",
                table: "Calls",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_LoggedById",
                table: "Calls",
                column: "LoggedById");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_PriorityId",
                table: "Calls",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_StatusId",
                table: "Calls",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Calls_UserModifiedId",
                table: "Calls",
                column: "UserModifiedId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CustomerId",
                table: "Contacts",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calls");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CallCategories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CallPriorities");

            migrationBuilder.DropTable(
                name: "CallStatus");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
