using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeApp.Migrations
{
    /// <inheritdoc />
    public partial class AdminLogAdd3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminLogs",
                table: "AdminLogs");

            migrationBuilder.RenameTable(
                name: "AdminLogs",
                newName: "AdminLog");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminLog",
                table: "AdminLog",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminLog",
                table: "AdminLog");

            migrationBuilder.RenameTable(
                name: "AdminLog",
                newName: "AdminLogs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminLogs",
                table: "AdminLogs",
                column: "Id");
        }
    }
}
