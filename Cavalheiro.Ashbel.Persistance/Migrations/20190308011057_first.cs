using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cavalheiro.Ashbel.Persistance.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aula",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Mes = table.Column<int>(nullable: false),
                    Dia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aula", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PessoaInfoAdicional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    IdConjugue = table.Column<int>(nullable: false),
                    IdPai = table.Column<int>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Profissao = table.Column<string>(nullable: true),
                    Empresa = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    NaturalCidade = table.Column<string>(nullable: true),
                    NaturalEstado = table.Column<string>(nullable: true),
                    NaturalPais = table.Column<string>(nullable: true),
                    MembroProfesso = table.Column<bool>(nullable: false),
                    Batizado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaInfoAdicional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusPessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoOrgao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    VigenciaAnos = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOrgao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    IdadeMinima = table.Column<int>(nullable: false),
                    IdadeMaxima = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Membro = table.Column<bool>(nullable: false),
                    IdStatusPessoa = table.Column<int>(nullable: false),
                    InfoAdicionalId = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: true),
                    ConjugueId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Pessoa_ConjugueId",
                        column: x => x.ConjugueId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_PessoaInfoAdicional_InfoAdicionalId",
                        column: x => x.InfoAdicionalId,
                        principalTable: "PessoaInfoAdicional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pessoa_StatusPessoa_StatusId",
                        column: x => x.StatusId,
                        principalTable: "StatusPessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assunto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    IdTema = table.Column<int>(nullable: false),
                    TemaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assunto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assunto_Tema_TemaId",
                        column: x => x.TemaId,
                        principalTable: "Tema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orgao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    IdTipoOrgao = table.Column<int>(nullable: false),
                    TipoOrgaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orgao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orgao_TipoOrgao_TipoOrgaoId",
                        column: x => x.TipoOrgaoId,
                        principalTable: "TipoOrgao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    IdTurma = table.Column<int>(nullable: false),
                    Matriculado = table.Column<bool>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true),
                    TurmaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Aluno_Turma_TurmaId",
                        column: x => x.TurmaId,
                        principalTable: "Turma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaContato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    TelefoneCelular = table.Column<string>(nullable: true),
                    TelefoneFixo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PessoaModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaContato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaContato_Pessoa_PessoaModelId",
                        column: x => x.PessoaModelId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaEndereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    CEP = table.Column<int>(nullable: false),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    PessoaModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaEndereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaEndereco_Pessoa_PessoaModelId",
                        column: x => x.PessoaModelId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CargoOrgao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdCargo = table.Column<int>(nullable: false),
                    IdOrgao = table.Column<int>(nullable: false),
                    CargoId = table.Column<int>(nullable: true),
                    OrgaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoOrgao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoOrgao_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CargoOrgao_Orgao_OrgaoId",
                        column: x => x.OrgaoId,
                        principalTable: "Orgao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroPresenca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdAula = table.Column<int>(nullable: false),
                    IdAluno = table.Column<int>(nullable: false),
                    TrouxeBiblia = table.Column<bool>(nullable: false),
                    Presente = table.Column<bool>(nullable: false),
                    Visita = table.Column<bool>(nullable: false),
                    AulaId = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroPresenca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroPresenca_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistroPresenca_Aula_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaOrgao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false),
                    IdPessoa = table.Column<int>(nullable: false),
                    IdOrgao = table.Column<int>(nullable: false),
                    IdCargo_Orgao = table.Column<int>(nullable: false),
                    DataFimVigencia = table.Column<DateTime>(nullable: false),
                    PessoaId = table.Column<int>(nullable: true),
                    OrgaoId = table.Column<int>(nullable: true),
                    CargoOrgaoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaOrgao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaOrgao_CargoOrgao_CargoOrgaoId",
                        column: x => x.CargoOrgaoId,
                        principalTable: "CargoOrgao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PessoaOrgao_Pessoa_OrgaoId",
                        column: x => x.OrgaoId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PessoaOrgao_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_PessoaId",
                table: "Aluno",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_TurmaId",
                table: "Aluno",
                column: "TurmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Assunto_TemaId",
                table: "Assunto",
                column: "TemaId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoOrgao_CargoId",
                table: "CargoOrgao",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoOrgao_OrgaoId",
                table: "CargoOrgao",
                column: "OrgaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orgao_TipoOrgaoId",
                table: "Orgao",
                column: "TipoOrgaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_ConjugueId",
                table: "Pessoa",
                column: "ConjugueId",
                unique: true,
                filter: "[ConjugueId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_InfoAdicionalId",
                table: "Pessoa",
                column: "InfoAdicionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_StatusId",
                table: "Pessoa",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaContato_PessoaModelId",
                table: "PessoaContato",
                column: "PessoaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaEndereco_PessoaModelId",
                table: "PessoaEndereco",
                column: "PessoaModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaOrgao_CargoOrgaoId",
                table: "PessoaOrgao",
                column: "CargoOrgaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaOrgao_OrgaoId",
                table: "PessoaOrgao",
                column: "OrgaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaOrgao_PessoaId",
                table: "PessoaOrgao",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroPresenca_AlunoId",
                table: "RegistroPresenca",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroPresenca_AulaId",
                table: "RegistroPresenca",
                column: "AulaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assunto");

            migrationBuilder.DropTable(
                name: "PessoaContato");

            migrationBuilder.DropTable(
                name: "PessoaEndereco");

            migrationBuilder.DropTable(
                name: "PessoaOrgao");

            migrationBuilder.DropTable(
                name: "RegistroPresenca");

            migrationBuilder.DropTable(
                name: "Tema");

            migrationBuilder.DropTable(
                name: "CargoOrgao");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Aula");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Orgao");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "TipoOrgao");

            migrationBuilder.DropTable(
                name: "PessoaInfoAdicional");

            migrationBuilder.DropTable(
                name: "StatusPessoa");
        }
    }
}
