using Microsoft.EntityFrameworkCore.Migrations;

namespace projeto_gama_jobsnet.Migrations
{
    public partial class vagaAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vagas",
                columns: table => new
                {
                    vaga_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vaga = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    descricao_vaga = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vagas", x => x.vaga_id);
                });

            migrationBuilder.CreateTable(
                name: "candidatos",
                columns: table => new
                {
                    candidato_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    estado_civil = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    genero = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    data_nascimento = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    cep = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: false),
                    endereco = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    numero = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    complemento = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    bairro = table.Column<string>(type: "varchar(25)", maxLength: 25, nullable: false),
                    cidade = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    telefone_fixo = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: true),
                    telefone_movel = table.Column<string>(type: "varchar(14)", maxLength: 14, nullable: true),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    cpf = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    rg = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    possui_veiculo = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    habilitacao = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    vaga_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatos", x => x.candidato_id);
                    table.ForeignKey(
                        name: "FK_candidatos_vagas_vaga_id",
                        column: x => x.vaga_id,
                        principalTable: "vagas",
                        principalColumn: "vaga_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_candidatos_vaga_id",
                table: "candidatos",
                column: "vaga_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidatos");

            migrationBuilder.DropTable(
                name: "vagas");
        }
    }
}
