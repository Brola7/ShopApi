using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class pricetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "RAMs",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "RAMs",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "MotherBoards",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "MotherBoards",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "CPUs",
                newName: "price");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "VideoCards",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "RAMs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "MotherBoards",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "price",
                table: "CPUs",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stock",
                table: "RAMs",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "RAMs",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "stock",
                table: "MotherBoards",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "MotherBoards",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "CPUs",
                newName: "Price");

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "VideoCards",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "RAMs",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "MotherBoards",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "CPUs",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
