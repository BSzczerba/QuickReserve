using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuickReserve.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoesItDeliver",
                table: "Restaurants");

            migrationBuilder.AddColumn<string>(
                name: "EncodedName",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EncodedName",
                table: "Restaurants");

            migrationBuilder.AddColumn<bool>(
                name: "DoesItDeliver",
                table: "Restaurants",
                type: "bit",
                nullable: true);
        }
    }
}
