using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore07.Migrations
{
    /// <inheritdoc />
    public partial class inheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Particpants");

            migrationBuilder.AddColumn<string>(
                name: "ParticpantType",
                table: "Particpants",
                type: "varchar(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParticpantType",
                table: "Particpants");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Particpants",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }
    }
}
