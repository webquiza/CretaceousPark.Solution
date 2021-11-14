using Microsoft.EntityFrameworkCore.Migrations;

namespace CretaceousPark.Migrations
{
    public partial class PageNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "varchar(20) CHARACTER SET utf8mb4",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PageNumber",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "PageNumber",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "PageNumber",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "PageNumber",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4,
                column: "PageNumber",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5,
                column: "PageNumber",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageNumber",
                table: "Animals");

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20) CHARACTER SET utf8mb4",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Animals",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");
        }
    }
}
