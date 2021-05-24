using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventOrganizer.PersistenceEF.Migrations
{
    public partial class ParticipantEmailToUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 7, 23, 19, 35, 18, 389, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 8, 23, 19, 35, 18, 395, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 10, 23, 19, 35, 18, 396, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 8, 29, 19, 35, 18, 396, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 9, 13, 0, 35, 18, 396, DateTimeKind.Local).AddTicks(90));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 7, 23, 18, 40, 52, 915, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 8, 23, 18, 40, 52, 925, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2021, 10, 23, 18, 40, 52, 925, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2021, 8, 29, 18, 40, 52, 925, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2021, 9, 12, 23, 40, 52, 925, DateTimeKind.Local).AddTicks(3356));
        }
    }
}
