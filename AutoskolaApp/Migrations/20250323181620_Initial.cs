using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AutoskolaApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    IDUloge = table.Column<Guid>(type: "TEXT", nullable: false),
                    ImeUloge = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.IDUloge);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    IDKorisnika = table.Column<Guid>(type: "TEXT", nullable: false),
                    KorisnickoIme = table.Column<string>(type: "TEXT", nullable: false),
                    Lozinka = table.Column<string>(type: "TEXT", nullable: false),
                    UlogaIDUloge = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.IDKorisnika);
                    table.ForeignKey(
                        name: "FK_Korisnici_Uloge_UlogaIDUloge",
                        column: x => x.UlogaIDUloge,
                        principalTable: "Uloge",
                        principalColumn: "IDUloge",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administratori",
                columns: table => new
                {
                    IDAdministratora = table.Column<Guid>(type: "TEXT", nullable: false),
                    OIB = table.Column<string>(type: "TEXT", nullable: false),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Prezime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratori", x => x.IDAdministratora);
                    table.ForeignKey(
                        name: "FK_Administratori_Korisnici_IDAdministratora",
                        column: x => x.IDAdministratora,
                        principalTable: "Korisnici",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instruktori",
                columns: table => new
                {
                    IDInstruktor = table.Column<Guid>(type: "TEXT", nullable: false),
                    OIB = table.Column<string>(type: "TEXT", nullable: false),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Prezime = table.Column<string>(type: "TEXT", nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Napomena = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruktori", x => x.IDInstruktor);
                    table.ForeignKey(
                        name: "FK_Instruktori_Korisnici_IDInstruktor",
                        column: x => x.IDInstruktor,
                        principalTable: "Korisnici",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    IDStudenta = table.Column<Guid>(type: "TEXT", nullable: false),
                    OIB = table.Column<string>(type: "TEXT", nullable: false),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Prezime = table.Column<string>(type: "TEXT", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SatiVoznje = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.IDStudenta);
                    table.ForeignKey(
                        name: "FK_Studenti_Korisnici_IDStudenta",
                        column: x => x.IDStudenta,
                        principalTable: "Korisnici",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ispiti",
                columns: table => new
                {
                    IDIspita = table.Column<Guid>(type: "TEXT", nullable: false),
                    DateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VrstaIspita = table.Column<string>(type: "TEXT", nullable: false),
                    InstruktorIDInstruktor = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ispiti", x => x.IDIspita);
                    table.ForeignKey(
                        name: "FK_Ispiti_Instruktori_InstruktorIDInstruktor",
                        column: x => x.InstruktorIDInstruktor,
                        principalTable: "Instruktori",
                        principalColumn: "IDInstruktor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    Registracija = table.Column<string>(type: "TEXT", nullable: false),
                    Marka = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    InstruktorIDInstruktor = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.Registracija);
                    table.ForeignKey(
                        name: "FK_Vozila_Instruktori_InstruktorIDInstruktor",
                        column: x => x.InstruktorIDInstruktor,
                        principalTable: "Instruktori",
                        principalColumn: "IDInstruktor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplate",
                columns: table => new
                {
                    IDUplate = table.Column<Guid>(type: "TEXT", nullable: false),
                    DatumUplate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Iznos = table.Column<decimal>(type: "TEXT", nullable: false),
                    NacinUplate = table.Column<string>(type: "TEXT", nullable: false),
                    StudentIDStudenta = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.IDUplate);
                    table.ForeignKey(
                        name: "FK_Uplate_Studenti_StudentIDStudenta",
                        column: x => x.StudentIDStudenta,
                        principalTable: "Studenti",
                        principalColumn: "IDStudenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voznje",
                columns: table => new
                {
                    IDVoznje = table.Column<Guid>(type: "TEXT", nullable: false),
                    DatumVoznje = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentIDStudenta = table.Column<Guid>(type: "TEXT", nullable: false),
                    InstruktorIDInstruktor = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznje", x => x.IDVoznje);
                    table.ForeignKey(
                        name: "FK_Voznje_Instruktori_InstruktorIDInstruktor",
                        column: x => x.InstruktorIDInstruktor,
                        principalTable: "Instruktori",
                        principalColumn: "IDInstruktor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voznje_Studenti_StudentIDStudenta",
                        column: x => x.StudentIDStudenta,
                        principalTable: "Studenti",
                        principalColumn: "IDStudenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolazniciIspita",
                columns: table => new
                {
                    IDPolaznika = table.Column<Guid>(type: "TEXT", nullable: false),
                    StudentIDStudenta = table.Column<Guid>(type: "TEXT", nullable: false),
                    IspitIDIspita = table.Column<Guid>(type: "TEXT", nullable: false),
                    Rezultat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolazniciIspita", x => x.IDPolaznika);
                    table.ForeignKey(
                        name: "FK_PolazniciIspita_Ispiti_IspitIDIspita",
                        column: x => x.IspitIDIspita,
                        principalTable: "Ispiti",
                        principalColumn: "IDIspita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolazniciIspita_Studenti_StudentIDStudenta",
                        column: x => x.StudentIDStudenta,
                        principalTable: "Studenti",
                        principalColumn: "IDStudenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "IDUloge", "ImeUloge" },
                values: new object[,]
                {
                    { new Guid("33eae27b-fb07-4267-bba0-2e5d16e056a4"), "Instruktor" },
                    { new Guid("7ff139de-2cdc-421c-853c-c9b7773a89f6"), "Student" },
                    { new Guid("bbb87d3f-4ca2-46e9-bc0b-7fd0e3d25d77"), "Administrator" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ispiti_InstruktorIDInstruktor",
                table: "Ispiti",
                column: "InstruktorIDInstruktor");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogaIDUloge",
                table: "Korisnici",
                column: "UlogaIDUloge");

            migrationBuilder.CreateIndex(
                name: "IX_PolazniciIspita_IspitIDIspita",
                table: "PolazniciIspita",
                column: "IspitIDIspita");

            migrationBuilder.CreateIndex(
                name: "IX_PolazniciIspita_StudentIDStudenta",
                table: "PolazniciIspita",
                column: "StudentIDStudenta");

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_StudentIDStudenta",
                table: "Uplate",
                column: "StudentIDStudenta");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_InstruktorIDInstruktor",
                table: "Vozila",
                column: "InstruktorIDInstruktor");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_InstruktorIDInstruktor",
                table: "Voznje",
                column: "InstruktorIDInstruktor");

            migrationBuilder.CreateIndex(
                name: "IX_Voznje_StudentIDStudenta",
                table: "Voznje",
                column: "StudentIDStudenta");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administratori");

            migrationBuilder.DropTable(
                name: "PolazniciIspita");

            migrationBuilder.DropTable(
                name: "Uplate");

            migrationBuilder.DropTable(
                name: "Vozila");

            migrationBuilder.DropTable(
                name: "Voznje");

            migrationBuilder.DropTable(
                name: "Ispiti");

            migrationBuilder.DropTable(
                name: "Studenti");

            migrationBuilder.DropTable(
                name: "Instruktori");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Uloge");
        }
    }
}
