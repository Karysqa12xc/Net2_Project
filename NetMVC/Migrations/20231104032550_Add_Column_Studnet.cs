using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetMVC.Migrations
{
    /// <inheritdoc />
    public partial class Add_Column_Studnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Students",
                newName: "Fullname");

            migrationBuilder.AlterColumn<string>(
                name: "Fullname",
                table: "Students",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Students",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");

            migrationBuilder.AlterColumn<string>(
                name: "PersonID",
                table: "Persons",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Students",
                newName: "FullName");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Students",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Students",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Persons",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Persons",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PersonID",
                table: "Persons",
                type: "Text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
