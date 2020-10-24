using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea5_.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Secretos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Valor_Moneda = table.Column<string>(nullable: true),
                    Fecha = table.Column<string>(nullable: true),
                    Lugar = table.Column<string>(nullable: true),
                    Lat_y_Long = table.Column<string>(nullable: true),
                    Usuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cedula = table.Column<string>(nullable: true),
                    Clave = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Secretos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
