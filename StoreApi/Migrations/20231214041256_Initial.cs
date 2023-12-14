using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Category = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(36)", unicode: false, maxLength: 36, nullable: false),
                    StaffId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Position = table.Column<byte>(type: "tinyint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    EffectedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pricing",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(36)", nullable: false),
                    EffectedFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pricing_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Code", "CreatedOn", "LastUpdatedOn", "Name" },
                values: new object[] { "89a83a5a-38df-40fc-ba43-a4a8e6264fcb", (byte)4, "PRD001", new DateTime(2023, 12, 14, 11, 12, 56, 17, DateTimeKind.Local).AddTicks(2833), null, "Nike Jacket" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Code", "CreatedOn", "LastUpdatedOn", "Name" },
                values: new object[] { "b87be491-69ba-4be1-8234-cb0a612dfcbd", (byte)1, "PRD002", new DateTime(2023, 12, 14, 11, 12, 56, 17, DateTimeKind.Local).AddTicks(2851), null, "Puma Shirt" });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "CreatedOn", "EffectedFrom", "LastUpdatedOn", "Position", "SName", "StaffId" },
                values: new object[] { "0abf92d7-d58c-4bb5-9c17-bc217968274f", new DateTime(2023, 12, 14, 11, 12, 56, 18, DateTimeKind.Local).AddTicks(152), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, (byte)2, "Rothna", "STF001" });

            migrationBuilder.CreateIndex(
                name: "IX_Pricing_ProductId",
                table: "Pricing",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Code",
                table: "Products",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_StaffId",
                table: "Staffs",
                column: "StaffId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pricing");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
