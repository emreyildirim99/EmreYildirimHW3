using Microsoft.EntityFrameworkCore.Migrations;

namespace CetTodoWeb.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userID",
                table: "Categories",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_userID",
                table: "Categories",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_userID",
                table: "Categories",
                column: "userID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_userID",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_userID",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "userID",
                table: "Categories");
        }
    }
}
