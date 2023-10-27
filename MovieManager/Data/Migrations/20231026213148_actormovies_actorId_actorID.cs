using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManager.Migrations
{
    public partial class actormovies_actorId_actorID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Movie_MovieID",
                table: "ActorMovie");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Movie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "ActorMovie",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_ActorMovie_MovieID",
                table: "ActorMovie",
                newName: "IX_ActorMovie_MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Movie_MovieId",
                table: "ActorMovie",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorMovie_Movie_MovieId",
                table: "ActorMovie");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movie",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ActorMovie",
                newName: "MovieID");

            migrationBuilder.RenameIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                newName: "IX_ActorMovie_MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorMovie_Movie_MovieID",
                table: "ActorMovie",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "ID");
        }
    }
}
