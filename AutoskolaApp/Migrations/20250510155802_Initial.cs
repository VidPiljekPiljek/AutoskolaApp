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
                    IDUloge = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    IDUloge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.IDKorisnika);
                    table.ForeignKey(
                        name: "FK_Korisnici_Uloge_IDUloge",
                        column: x => x.IDUloge,
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
                    Prezime = table.Column<string>(type: "TEXT", nullable: false),
                    IDKorisnika = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratori", x => x.IDAdministratora);
                    table.ForeignKey(
                        name: "FK_Administratori_Korisnici_IDKorisnika",
                        column: x => x.IDKorisnika,
                        principalTable: "Korisnici",
                        principalColumn: "IDKorisnika",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instruktori",
                columns: table => new
                {
                    IDInstruktora = table.Column<Guid>(type: "TEXT", nullable: false),
                    OIB = table.Column<string>(type: "TEXT", nullable: false),
                    Ime = table.Column<string>(type: "TEXT", nullable: false),
                    Prezime = table.Column<string>(type: "TEXT", nullable: false),
                    DatumZaposlenja = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Napomena = table.Column<string>(type: "TEXT", nullable: true),
                    IDKorisnika = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruktori", x => x.IDInstruktora);
                    table.ForeignKey(
                        name: "FK_Instruktori_Korisnici_IDKorisnika",
                        column: x => x.IDKorisnika,
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
                    SatiVoznje = table.Column<int>(type: "INTEGER", nullable: false),
                    IDKorisnika = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.IDStudenta);
                    table.ForeignKey(
                        name: "FK_Studenti_Korisnici_IDKorisnika",
                        column: x => x.IDKorisnika,
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
                    IDInstruktora = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ispiti", x => x.IDIspita);
                    table.ForeignKey(
                        name: "FK_Ispiti_Instruktori_IDIspita",
                        column: x => x.IDIspita,
                        principalTable: "Instruktori",
                        principalColumn: "IDInstruktora",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    Registracija = table.Column<string>(type: "TEXT", nullable: false),
                    Marka = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    IDInstruktora = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.Registracija);
                    table.ForeignKey(
                        name: "FK_Vozila_Instruktori_IDInstruktora",
                        column: x => x.IDInstruktora,
                        principalTable: "Instruktori",
                        principalColumn: "IDInstruktora",
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
                    IDStudenta = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplate", x => x.IDUplate);
                    table.ForeignKey(
                        name: "FK_Uplate_Studenti_IDStudenta",
                        column: x => x.IDStudenta,
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
                    IDStudenta = table.Column<Guid>(type: "TEXT", nullable: false),
                    IDInstruktora = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voznje", x => x.IDVoznje);
                    table.ForeignKey(
                        name: "FK_Voznje_Instruktori_IDVoznje",
                        column: x => x.IDVoznje,
                        principalTable: "Instruktori",
                        principalColumn: "IDInstruktora",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Voznje_Studenti_IDVoznje",
                        column: x => x.IDVoznje,
                        principalTable: "Studenti",
                        principalColumn: "IDStudenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PolazniciIspita",
                columns: table => new
                {
                    IDPolaznika = table.Column<Guid>(type: "TEXT", nullable: false),
                    IDStudenta = table.Column<Guid>(type: "TEXT", nullable: false),
                    IDIspita = table.Column<Guid>(type: "TEXT", nullable: false),
                    Rezultat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolazniciIspita", x => x.IDPolaznika);
                    table.ForeignKey(
                        name: "FK_PolazniciIspita_Ispiti_IDIspita",
                        column: x => x.IDIspita,
                        principalTable: "Ispiti",
                        principalColumn: "IDIspita",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PolazniciIspita_Studenti_IDStudenta",
                        column: x => x.IDStudenta,
                        principalTable: "Studenti",
                        principalColumn: "IDStudenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "IDUloge", "ImeUloge" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Instruktor" },
                    { 3, "Student" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "IDKorisnika", "IDUloge", "KorisnickoIme", "Lozinka" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), 1, "admin", "adminautoskola" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), 1, "instruktortest", "instruktortest" }
                });

            migrationBuilder.InsertData(
                table: "Administratori",
                columns: new[] { "IDAdministratora", "IDKorisnika", "Ime", "OIB", "Prezime" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000001"), "Vid", "17232937055", "Piljek" });

            migrationBuilder.InsertData(
                table: "Instruktori",
                columns: new[] { "IDInstruktora", "DatumZaposlenja", "IDKorisnika", "Ime", "Napomena", "OIB", "Prezime" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000002"), "Leon", null, "17235938955", "Plecko" });

            migrationBuilder.CreateIndex(
                name: "IX_Administratori_IDKorisnika",
                table: "Administratori",
                column: "IDKorisnika",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instruktori_IDKorisnika",
                table: "Instruktori",
                column: "IDKorisnika",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_IDUloge",
                table: "Korisnici",
                column: "IDUloge");

            migrationBuilder.CreateIndex(
                name: "IX_PolazniciIspita_IDIspita",
                table: "PolazniciIspita",
                column: "IDIspita");

            migrationBuilder.CreateIndex(
                name: "IX_PolazniciIspita_IDStudenta",
                table: "PolazniciIspita",
                column: "IDStudenta");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_IDKorisnika",
                table: "Studenti",
                column: "IDKorisnika",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Uplate_IDStudenta",
                table: "Uplate",
                column: "IDStudenta");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_IDInstruktora",
                table: "Vozila",
                column: "IDInstruktora",
                unique: true);
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
