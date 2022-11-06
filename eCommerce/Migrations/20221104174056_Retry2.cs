using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCommerce.Migrations
{
    public partial class Retry2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId1",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publication_AuthorId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorId1",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Book");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublicationId",
                table: "Book",
                column: "PublicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publication_PublicationId",
                table: "Book",
                column: "PublicationId",
                principalTable: "Publication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publication_PublicationId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublicationId",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId1",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId1",
                table: "Book",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId1",
                table: "Book",
                column: "AuthorId1",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publication_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Publication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
