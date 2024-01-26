using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuCrudMvc.Migrations
{
    /// <inheritdoc />
    public partial class Inicialcriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    cadastroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "char(100)", nullable: true),
                    dataNasc = table.Column<DateTime>(type: "date", nullable: true),
                    email = table.Column<string>(type: "char(150)", nullable: true),
                    enderecoId = table.Column<int>(type: "int", nullable: true),
                    telefoneId = table.Column<int>(type: "int", nullable: true),
                    telefone = table.Column<string>(type: "char(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.cadastroId);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");
        }
    }
}
