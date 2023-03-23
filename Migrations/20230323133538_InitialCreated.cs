using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkCore.LittleMarket.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uruns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlinanUruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlinanUruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlinanUruns_Firmas_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlinanUruns_Uruns_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SatilanUruns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Miktar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatilanUruns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SatilanUruns_Firmas_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SatilanUruns_Uruns_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Uruns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlinanUruns_FirmaId",
                table: "AlinanUruns",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_AlinanUruns_UrunId",
                table: "AlinanUruns",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_SatilanUruns_FirmaId",
                table: "SatilanUruns",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_SatilanUruns_UrunId",
                table: "SatilanUruns",
                column: "UrunId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlinanUruns");

            migrationBuilder.DropTable(
                name: "SatilanUruns");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "Uruns");
        }
    }
}
