using Microsoft.EntityFrameworkCore.Migrations;

namespace proyectofinal.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Proveedor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombreEmpresa",
                table: "Proveedor",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Proveedor",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Proveedor",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Proveedor",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "nombreEmpresa",
                table: "Proveedor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Proveedor",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "correo",
                table: "Proveedor",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
