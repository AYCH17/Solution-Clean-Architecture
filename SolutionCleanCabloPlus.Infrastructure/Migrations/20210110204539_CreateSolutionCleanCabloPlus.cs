using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolutionCleanCabloPlus.Infrastructure.Migrations
{
    public partial class CreateSolutionCleanCabloPlus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    montantLocation = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceDiffusions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceDiffusions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Territoires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territoires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    téléphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    territoireId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raisonSociale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prénom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Territoires_territoireId",
                        column: x => x.territoireId,
                        principalTable: "Territoires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employés",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fonction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mdp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prénom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    téléphone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salaire = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    territoireId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employés", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employés_Territoires_territoireId",
                        column: x => x.territoireId,
                        principalTable: "Territoires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstDesserviDans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    territoireId = table.Column<int>(type: "int", nullable: false),
                    serviceDiffusionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstDesserviDans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstDesserviDans_ServiceDiffusions_serviceDiffusionId",
                        column: x => x.serviceDiffusionId,
                        principalTable: "ServiceDiffusions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EstDesserviDans_Territoires_territoireId",
                        column: x => x.territoireId,
                        principalTable: "Territoires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comptes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    modeFacturation = table.Column<int>(type: "int", nullable: false),
                    solde = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dateCréation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    clientId = table.Column<int>(type: "int", nullable: false),
                    employéRCId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comptes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comptes_Clients_clientId",
                        column: x => x.clientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comptes_Employés_employéRCId",
                        column: x => x.employéRCId,
                        principalTable: "Employés",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompteServiceDiffusion",
                columns: table => new
                {
                    comptesId = table.Column<int>(type: "int", nullable: false),
                    serviceDiffusionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompteServiceDiffusion", x => new { x.comptesId, x.serviceDiffusionsId });
                    table.ForeignKey(
                        name: "FK_CompteServiceDiffusion_Comptes_comptesId",
                        column: x => x.comptesId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompteServiceDiffusion_ServiceDiffusions_serviceDiffusionsId",
                        column: x => x.serviceDiffusionsId,
                        principalTable: "ServiceDiffusions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tarifMensuelLocation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    compteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipements_Comptes_compteId",
                        column: x => x.compteId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Installations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    frais = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dateProgramation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateRéalisation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    compteId = table.Column<int>(type: "int", nullable: false),
                    technicienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Installations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Installations_Comptes_compteId",
                        column: x => x.compteId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Installations_Employés_technicienId",
                        column: x => x.technicienId,
                        principalTable: "Employés",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LoueFilms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    compteId = table.Column<int>(type: "int", nullable: true),
                    filmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoueFilms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoueFilms_Comptes_compteId",
                        column: x => x.compteId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LoueFilms_Films_filmId",
                        column: x => x.filmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Paiements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    compteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paiements_Comptes_compteId",
                        column: x => x.compteId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branchements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    localisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    compteId = table.Column<int>(type: "int", nullable: true),
                    installationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branchements_Comptes_compteId",
                        column: x => x.compteId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branchements_Installations_installationId",
                        column: x => x.installationId,
                        principalTable: "Installations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    montantFilms = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    montantEquipements = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    montantServicesDiffusion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    montantInstallation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    payée = table.Column<bool>(type: "bit", nullable: false),
                    compteId = table.Column<int>(type: "int", nullable: true),
                    paiementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factures_Comptes_compteId",
                        column: x => x.compteId,
                        principalTable: "Comptes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factures_Paiements_paiementId",
                        column: x => x.paiementId,
                        principalTable: "Paiements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EquipementFacture",
                columns: table => new
                {
                    equipementsId = table.Column<int>(type: "int", nullable: false),
                    facturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipementFacture", x => new { x.equipementsId, x.facturesId });
                    table.ForeignKey(
                        name: "FK_EquipementFacture_Equipements_equipementsId",
                        column: x => x.equipementsId,
                        principalTable: "Equipements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EquipementFacture_Factures_facturesId",
                        column: x => x.facturesId,
                        principalTable: "Factures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactureFilm",
                columns: table => new
                {
                    facturesId = table.Column<int>(type: "int", nullable: false),
                    filmsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactureFilm", x => new { x.facturesId, x.filmsId });
                    table.ForeignKey(
                        name: "FK_FactureFilm_Factures_facturesId",
                        column: x => x.facturesId,
                        principalTable: "Factures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FactureFilm_Films_filmsId",
                        column: x => x.filmsId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FactureServiceDiffusion",
                columns: table => new
                {
                    facturesId = table.Column<int>(type: "int", nullable: false),
                    serviceDiffusionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactureServiceDiffusion", x => new { x.facturesId, x.serviceDiffusionsId });
                    table.ForeignKey(
                        name: "FK_FactureServiceDiffusion_Factures_facturesId",
                        column: x => x.facturesId,
                        principalTable: "Factures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FactureServiceDiffusion_ServiceDiffusions_serviceDiffusionsId",
                        column: x => x.serviceDiffusionsId,
                        principalTable: "ServiceDiffusions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branchements_compteId",
                table: "Branchements",
                column: "compteId");

            migrationBuilder.CreateIndex(
                name: "IX_Branchements_installationId",
                table: "Branchements",
                column: "installationId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_territoireId",
                table: "Clients",
                column: "territoireId");

            migrationBuilder.CreateIndex(
                name: "IX_Comptes_clientId",
                table: "Comptes",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_Comptes_employéRCId",
                table: "Comptes",
                column: "employéRCId");

            migrationBuilder.CreateIndex(
                name: "IX_CompteServiceDiffusion_serviceDiffusionsId",
                table: "CompteServiceDiffusion",
                column: "serviceDiffusionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Employés_territoireId",
                table: "Employés",
                column: "territoireId",
                unique: true,
                filter: "[territoireId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EquipementFacture_facturesId",
                table: "EquipementFacture",
                column: "facturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipements_compteId",
                table: "Equipements",
                column: "compteId");

            migrationBuilder.CreateIndex(
                name: "IX_EstDesserviDans_serviceDiffusionId",
                table: "EstDesserviDans",
                column: "serviceDiffusionId");

            migrationBuilder.CreateIndex(
                name: "IX_EstDesserviDans_territoireId",
                table: "EstDesserviDans",
                column: "territoireId");

            migrationBuilder.CreateIndex(
                name: "IX_FactureFilm_filmsId",
                table: "FactureFilm",
                column: "filmsId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_compteId",
                table: "Factures",
                column: "compteId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_paiementId",
                table: "Factures",
                column: "paiementId",
                unique: true,
                filter: "[paiementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FactureServiceDiffusion_serviceDiffusionsId",
                table: "FactureServiceDiffusion",
                column: "serviceDiffusionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Installations_compteId",
                table: "Installations",
                column: "compteId");

            migrationBuilder.CreateIndex(
                name: "IX_Installations_technicienId",
                table: "Installations",
                column: "technicienId");

            migrationBuilder.CreateIndex(
                name: "IX_LoueFilms_compteId",
                table: "LoueFilms",
                column: "compteId");

            migrationBuilder.CreateIndex(
                name: "IX_LoueFilms_filmId",
                table: "LoueFilms",
                column: "filmId");

            migrationBuilder.CreateIndex(
                name: "IX_Paiements_compteId",
                table: "Paiements",
                column: "compteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branchements");

            migrationBuilder.DropTable(
                name: "CompteServiceDiffusion");

            migrationBuilder.DropTable(
                name: "EquipementFacture");

            migrationBuilder.DropTable(
                name: "EstDesserviDans");

            migrationBuilder.DropTable(
                name: "FactureFilm");

            migrationBuilder.DropTable(
                name: "FactureServiceDiffusion");

            migrationBuilder.DropTable(
                name: "LoueFilms");

            migrationBuilder.DropTable(
                name: "Installations");

            migrationBuilder.DropTable(
                name: "Equipements");

            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "ServiceDiffusions");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Paiements");

            migrationBuilder.DropTable(
                name: "Comptes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employés");

            migrationBuilder.DropTable(
                name: "Territoires");
        }
    }
}
