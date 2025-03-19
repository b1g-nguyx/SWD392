using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalRecords",
                columns: table => new
                {
                    RecordCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PatientCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BHYT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecords", x => x.RecordCode);
                });

            migrationBuilder.CreateTable(
                name: "MedicalRecordDetails",
                columns: table => new
                {
                    RecordDetailCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RecordCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorReport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthcareResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatmentPlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalRecordRecordCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalRecordDetails", x => x.RecordDetailCode);
                    table.ForeignKey(
                        name: "FK_MedicalRecordDetails_MedicalRecords_MedicalRecordRecordCode",
                        column: x => x.MedicalRecordRecordCode,
                        principalTable: "MedicalRecords",
                        principalColumn: "RecordCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalRecordDetails_MedicalRecordRecordCode",
                table: "MedicalRecordDetails",
                column: "MedicalRecordRecordCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalRecordDetails");

            migrationBuilder.DropTable(
                name: "MedicalRecords");
        }
    }
}
