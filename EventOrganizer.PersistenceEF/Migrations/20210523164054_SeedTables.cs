using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EventOrganizer.PersistenceEF.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "Przedstawimy zagadnienia, które będą wprowadzeniami do głębszego poznawania RESTful APIs.\r\n                    Pierwsze spotkanie będzie wstępem i przedstawieniemz szerszej perspektywy, kontekstu, do którego wrócimy \r\n                    na ostatnim spotkaniu z cyklu. Taka agendowa klamra wyczerpie temat RESTful API na wieki, a przynajmniej \r\n                    do kolejnego nowego pomysłu, zmiany wprowadzonej w świat IT.", new TimeSpan(0, 2, 0, 0, 0), new DateTime(2021, 7, 23, 18, 40, 52, 915, DateTimeKind.Local).AddTicks(6347), "Restful API, wszystkoco powinieneś wiedzieć." },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,\r\n                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  \r\n                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. \r\n                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. \r\n                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.", new TimeSpan(0, 4, 0, 0, 0), new DateTime(2021, 8, 23, 18, 40, 52, 925, DateTimeKind.Local).AddTicks(3094), "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit" },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,\r\n                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  \r\n                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. \r\n                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. \r\n                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.", new TimeSpan(0, 2, 15, 0, 0), new DateTime(2021, 10, 23, 18, 40, 52, 925, DateTimeKind.Local).AddTicks(3285), "Docker niech Twoja firma wypłynie na szerokie wody" },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,\r\n                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  \r\n                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. \r\n                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. \r\n                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.", new TimeSpan(0, 2, 30, 0, 0), new DateTime(2021, 8, 29, 18, 40, 52, 925, DateTimeKind.Local).AddTicks(3304), "JavaScript, TypeScript, czy może jakiś framework?" },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut eu felis mattis, viverra nibh in,\r\n                    condimentum ex. In hac habitasse platea dictumst. Pellentesque sodales vestibulum odio, et tempus leo faucibus pellentesque.  \r\n                    Cras mattis gravida mauris sit amet accumsan. Nunc vitae fermentum metus, nec tempus massa. \r\n                    Proin pulvinar elit eu mauris pharetra placerat. Proin ullamcorper hendrerit mi ac lacinia. \r\n                    Quisque elementum aliquet diam non eleifend. Curabitur ultrices mi enim, aliquet lacinia est fermentum et. Cras ut lorem risus.", new TimeSpan(0, 3, 45, 0, 0), new DateTime(2021, 9, 12, 23, 40, 52, 925, DateTimeKind.Local).AddTicks(3356), "ADO.NET bo Entity Framework już nie wystarcza, a być może nigdy nie wystarczał." }
                });

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "maria@gmail.com", "Maria" },
                    { 2, "tomek@gmail.com", "Tomek" },
                    { 3, "lili@gmail.com", "Lili" },
                    { 4, "kasia@gmail.com", "Kasia" }
                });

            migrationBuilder.InsertData(
                table: "EventsParticipants",
                columns: new[] { "Id", "EventId", "ParticipantId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 1 },
                    { 3, 5, 1 },
                    { 4, 2, 2 },
                    { 5, 5, 3 },
                    { 6, 4, 3 },
                    { 7, 3, 3 },
                    { 8, 1, 4 },
                    { 9, 5, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventsParticipants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
