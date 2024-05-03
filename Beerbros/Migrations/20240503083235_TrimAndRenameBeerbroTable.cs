using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beerbros.Web.Migrations
{
    /// <inheritdoc />
    public partial class TrimAndRenameBeerbroTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("beerbro", newName: "ratings");
            migrationBuilder.DropColumn(name: "Bier", table: "ratings");
            migrationBuilder.DropColumn(name: "Bild_URL", table: "ratings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable("ratings", newName: "beerbro");
            migrationBuilder.AddColumn<String>(name: "Bier", table: "beerbro");
            migrationBuilder.AddColumn<String>(name: "Bild_URL", table: "beerbro");
        }
    }
}
