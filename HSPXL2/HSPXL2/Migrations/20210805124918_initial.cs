using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HSPXL2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(maxLength: 30, nullable: false),
                    Voornaam = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });

            migrationBuilder.CreateTable(
                name: "Handboeks",
                columns: table => new
                {
                    HandboekID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    KostPrijs = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    UitgiftDatum = table.Column<DateTime>(nullable: false),
                    Afbeelding = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    CursusID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Handboeks", x => x.HandboekID);
                });

            migrationBuilder.CreateTable(
                name: "Cursus",
                columns: table => new
                {
                    CursusID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CursusName = table.Column<string>(nullable: false),
                    Studiepunten = table.Column<int>(nullable: false),
                    HandboekID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursus", x => x.CursusID);
                    table.ForeignKey(
                        name: "FK_Cursus_Handboeks_HandboekID",
                        column: x => x.HandboekID,
                        principalTable: "Handboeks",
                        principalColumn: "HandboekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inschrijvings",
                columns: table => new
                {
                    InschrijvingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<long>(nullable: false),
                    CursusID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inschrijvings", x => x.InschrijvingID);
                    table.ForeignKey(
                        name: "FK_Inschrijvings_Cursus_CursusID",
                        column: x => x.CursusID,
                        principalTable: "Cursus",
                        principalColumn: "CursusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inschrijvings_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursus_HandboekID",
                table: "Cursus",
                column: "HandboekID");

            migrationBuilder.CreateIndex(
                name: "IX_Handboeks_CursusID",
                table: "Handboeks",
                column: "CursusID");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvings_CursusID",
                table: "Inschrijvings",
                column: "CursusID");

            migrationBuilder.CreateIndex(
                name: "IX_Inschrijvings_StudentID",
                table: "Inschrijvings",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Handboeks_Cursus_CursusID",
                table: "Handboeks",
                column: "CursusID",
                principalTable: "Cursus",
                principalColumn: "CursusID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursus_Handboeks_HandboekID",
                table: "Cursus");

            migrationBuilder.DropTable(
                name: "Inschrijvings");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Handboeks");

            migrationBuilder.DropTable(
                name: "Cursus");
        }
    }
}
