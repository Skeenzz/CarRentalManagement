using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "c0b25612-e0f0-49a1-bfb8-31b8fe5009d6", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "73e5622d-fea1-4a6b-96df-d7f44c9656e9", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "0093e80f-03a1-49e2-b358-9880761ee187", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKiLTWyQcgWXraw4b+1vjQtNHEOql67K/F7QLGf+GInX8dHg5zsMM0QHWcj+8NXurw==", null, false, "2b6ec43c-ca41-4f1b-92e1-ce310290a095", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 10, 17, 55, 459, DateTimeKind.Local).AddTicks(6757), new DateTime(2021, 11, 24, 10, 17, 55, 460, DateTimeKind.Local).AddTicks(8374), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 10, 17, 55, 460, DateTimeKind.Local).AddTicks(9320), new DateTime(2021, 11, 24, 10, 17, 55, 460, DateTimeKind.Local).AddTicks(9325), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(1259), new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(1273), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(1277), new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(1278), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4823), new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4828), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4832), new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4833), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4834), new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4835), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4836), new DateTime(2021, 11, 24, 10, 17, 55, 462, DateTimeKind.Local).AddTicks(4837), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
