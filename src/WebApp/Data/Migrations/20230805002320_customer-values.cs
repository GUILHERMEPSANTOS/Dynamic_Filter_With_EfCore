using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class customervalues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(345),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 7, 29, 17, 2, 5, 976, DateTimeKind.Utc).AddTicks(2102));

            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "True");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Active", "DateOfBirth", "Email", "Name", "RegistrationDate" },
                values: new object[,]
                {
                    { new Guid("2852c44e-2005-4145-87ad-02c4e6619129"), true, new DateTime(2006, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1653), "ana123@gmail.com", "Ana", new DateTime(2021, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1651) },
                    { new Guid("7f20e568-3c03-4c02-8afb-0dcc6a5a2eed"), true, new DateTime(2004, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1658), "carlos45@yahoo.com", "Carlos", new DateTime(2019, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1657) },
                    { new Guid("7f40737b-3b0c-4917-b04a-01a58fd37c92"), true, new DateTime(2003, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1670), "rafael.mtz@gmail.com", "Rafael", new DateTime(2018, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1668) },
                    { new Guid("de186d50-d218-4c81-9dbc-9dff0ff39946"), true, new DateTime(2005, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1599), "guilherme@hotmail.com", "Guilherme", new DateTime(2020, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1582) },
                    { new Guid("f89acce8-8235-40c6-b515-c29e213b8e30"), true, new DateTime(2007, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1665), "maria87@hotmail.com", "Maria", new DateTime(2022, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(1663) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2852c44e-2005-4145-87ad-02c4e6619129"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7f20e568-3c03-4c02-8afb-0dcc6a5a2eed"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("7f40737b-3b0c-4917-b04a-01a58fd37c92"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("de186d50-d218-4c81-9dbc-9dff0ff39946"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f89acce8-8235-40c6-b515-c29e213b8e30"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 29, 17, 2, 5, 976, DateTimeKind.Utc).AddTicks(2102),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 5, 0, 23, 20, 314, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.AlterColumn<string>(
                name: "Active",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "True",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);
        }
    }
}
