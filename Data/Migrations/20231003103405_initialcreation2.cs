using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appPageRazor.Data.Migrations
{
    /// <inheritdoc />
    public partial class initialcreation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Livres",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Livres");
        }
    }
}
