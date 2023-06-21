using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KR.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActorFilm",
                columns: table => new
                {
                    ActorsActorId = table.Column<int>(type: "int", nullable: false),
                    FilmsFilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorFilm", x => new { x.ActorsActorId, x.FilmsFilmId });
                    table.ForeignKey(
                        name: "FK_ActorFilm_actor_ActorsActorId",
                        column: x => x.ActorsActorId,
                        principalTable: "actor",
                        principalColumn: "actor_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorFilm_film_FilmsFilmId",
                        column: x => x.FilmsFilmId,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFilm",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    FilmsFilmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFilm", x => new { x.CategoriesCategoryId, x.FilmsFilmId });
                    table.ForeignKey(
                        name: "FK_CategoryFilm_category_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "category",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFilm_film_FilmsFilmId",
                        column: x => x.FilmsFilmId,
                        principalTable: "film",
                        principalColumn: "film_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorFilm_FilmsFilmId",
                table: "ActorFilm",
                column: "FilmsFilmId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilm_FilmsFilmId",
                table: "CategoryFilm",
                column: "FilmsFilmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorFilm");

            migrationBuilder.DropTable(
                name: "CategoryFilm");
        }
    }
}
