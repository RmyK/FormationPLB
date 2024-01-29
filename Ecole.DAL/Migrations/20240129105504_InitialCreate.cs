using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonEcole.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ecoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fonctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fonctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matieres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Coefficient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matieres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EcoleId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FonctionId = table.Column<int>(type: "int", nullable: true),
                    Salaire = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Moyenne = table.Column<int>(type: "int", nullable: true),
                    MatiereId = table.Column<int>(type: "int", nullable: true),
                    Professeur_Salaire = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personne_Ecoles_EcoleId",
                        column: x => x.EcoleId,
                        principalTable: "Ecoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personne_Fonctions_FonctionId",
                        column: x => x.FonctionId,
                        principalTable: "Fonctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personne_Matieres_MatiereId",
                        column: x => x.MatiereId,
                        principalTable: "Matieres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ecoles",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 1, "St Exupéry" });

            migrationBuilder.InsertData(
                table: "Fonctions",
                columns: new[] { "Id", "Libelle", "Service" },
                values: new object[,]
                {
                    { 1, "Secretaire", "Administration" },
                    { 2, "Educateur", "Equipe pedagogique" },
                    { 3, "Directeur", "Administration" },
                    { 4, "CPE", "Equipe pedagogique" }
                });

            migrationBuilder.InsertData(
                table: "Matieres",
                columns: new[] { "Id", "Coefficient", "Libelle" },
                values: new object[,]
                {
                    { 1, 8, "Mathematique" },
                    { 2, 9, "Francais" },
                    { 3, 2, "Sport" },
                    { 4, 7, "Science" }
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "Id", "DateNaissance", "Discriminator", "EcoleId", "Moyenne", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, new DateTime(2012, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eleve", 1, 12, "Oumal", "Fabien" },
                    { 2, new DateTime(2009, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eleve", 1, 15, "DePoheur", "Agathe" }
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "Id", "DateNaissance", "Discriminator", "EcoleId", "FonctionId", "Nom", "Prenom", "Salaire" },
                values: new object[] { 5, new DateTime(1989, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administratif", 1, 3, "Sion", "Eva", 0m });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "Id", "DateNaissance", "Discriminator", "EcoleId", "MatiereId", "Nom", "Prenom", "Professeur_Salaire" },
                values: new object[,]
                {
                    { 4, new DateTime(1978, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professeur", 1, 3, "Mobil", "Otto", 0m },
                    { 3, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Professeur", 1, 4, "Erie", "Yann", 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personne_EcoleId",
                table: "Personne",
                column: "EcoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Personne_FonctionId",
                table: "Personne",
                column: "FonctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personne_MatiereId",
                table: "Personne",
                column: "MatiereId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personne");

            migrationBuilder.DropTable(
                name: "Ecoles");

            migrationBuilder.DropTable(
                name: "Fonctions");

            migrationBuilder.DropTable(
                name: "Matieres");
        }
    }
}
