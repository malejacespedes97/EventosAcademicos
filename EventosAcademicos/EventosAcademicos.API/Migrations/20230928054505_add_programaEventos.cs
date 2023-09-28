using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventosAcademicos.API.Migrations
{
    /// <inheritdoc />
    public partial class add_programaEventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramaEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaInicio = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    FechaFinal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Ubicacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TemaEvento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramaEventos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramaEventos");
        }
    }
}
