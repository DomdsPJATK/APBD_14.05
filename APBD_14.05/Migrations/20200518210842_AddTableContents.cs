using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBD_14._05.Migrations
{
    public partial class AddTableContents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "pawel.lekarski@gmail.com", "Paweł", "Lekarski" });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[] { 1, "Super lek, nie przedawkujesz mordo!", "Paracetamol", "Przeciwbólowy/Przeciwgorączkowy" });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2001, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kacper", "Bolinoga" });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(1981, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "Prescription_Medicament",
                columns: new[] { "IdPrescription", "Details", "Dose", "IdMecidament" },
                values: new object[] { 1, "Tylko na pusty żołądek", 50, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription_Medicament",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);
        }
    }
}
