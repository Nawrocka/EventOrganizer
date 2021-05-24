using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventOrganizer.PersistenceEF.Migrations
{
    public partial class Event_Add_MaxParticipants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxParticipants",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxParticipants", "StartDate" },
                values: new object[] { 2, new DateTime(2021, 7, 24, 18, 30, 26, 312, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2021, 8, 24, 18, 30, 26, 320, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MaxParticipants", "StartDate" },
                values: new object[] { 2, new DateTime(2021, 10, 24, 18, 30, 26, 320, DateTimeKind.Local).AddTicks(4016) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MaxParticipants", "StartDate" },
                values: new object[] { 3, new DateTime(2021, 8, 30, 18, 30, 26, 320, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MaxParticipants", "StartDate" },
                values: new object[] { 3, new DateTime(2021, 9, 13, 23, 30, 26, 320, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "MaxParticipants", "StartDate", "Title" },
                values: new object[] { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,\r\n                        condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  \r\n                        Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. \r\n                        Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. \r\n                        Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.", new TimeSpan(0, 3, 45, 0, 0), 25, new DateTime(2021, 9, 13, 23, 30, 26, 320, DateTimeKind.Local).AddTicks(4099), "Seeding data to test MaxParticipants prop - it doesn't have tied real participants" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "MaxParticipants",
                table: "Events");

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
    }
}
