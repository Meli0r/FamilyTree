using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FamilyTree.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "family_tree");

            migrationBuilder.CreateTable(
                name: "people",
                schema: "family_tree",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(maxLength: 30, nullable: true),
                    surname = table.Column<string>(maxLength: 30, nullable: true),
                    birthdate = table.Column<DateTime>(nullable: false),
                    spouse_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_people", x => x.id);
                    table.ForeignKey(
                        name: "fk_people_people_spouse_id",
                        column: x => x.spouse_id,
                        principalSchema: "family_tree",
                        principalTable: "people",
                        principalColumn: "id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "ix_people_spouse_id",
                schema: "family_tree",
                table: "people",
                column: "spouse_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "people",
                schema: "family_tree");
        }
    }
}
