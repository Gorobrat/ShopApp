using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopApiApp.Migrations
{
    /// <inheritdoc />
    public partial class phonenum_change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNum",
                table: "Users",
                newName: "PhoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Users",
                newName: "PhoneNum");
        }
    }
}
