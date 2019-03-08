﻿// <auto-generated />
using System;
using Cavalheiro.Ashbel.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cavalheiro.Ashbel.Persistance.Migrations
{
    [DbContext(typeof(AshbelDbContext))]
    [Migration("20190308011057_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.AlunoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("IdPessoa");

                    b.Property<int>("IdTurma");

                    b.Property<bool>("Matriculado");

                    b.Property<int?>("PessoaId");

                    b.Property<int?>("TurmaId");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.AssuntoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdTema");

                    b.Property<int?>("TemaId");

                    b.Property<string>("Titulo");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("TemaId");

                    b.ToTable("Assunto");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.AulaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("Dia");

                    b.Property<int>("Mes");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.ToTable("Aula");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.CargoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.CargoOrgaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("CargoId");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("IdCargo");

                    b.Property<int>("IdOrgao");

                    b.Property<int?>("OrgaoId");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("OrgaoId");

                    b.ToTable("CargoOrgao");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.OrgaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("IdTipoOrgao");

                    b.Property<string>("Nome");

                    b.Property<int?>("TipoOrgaoId");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("TipoOrgaoId");

                    b.ToTable("Orgao");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaContatoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Email");

                    b.Property<int>("IdPessoa");

                    b.Property<int?>("PessoaModelId");

                    b.Property<string>("TelefoneCelular");

                    b.Property<string>("TelefoneFixo");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("PessoaModelId");

                    b.ToTable("PessoaContato");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaEnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Bairro");

                    b.Property<int>("CEP");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Endereco");

                    b.Property<string>("Estado");

                    b.Property<int>("IdPessoa");

                    b.Property<string>("Numero");

                    b.Property<int?>("PessoaModelId");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("PessoaModelId");

                    b.ToTable("PessoaEndereco");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaInfoAdicionalModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<bool>("Batizado");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Empresa");

                    b.Property<byte[]>("Foto");

                    b.Property<int>("IdConjugue");

                    b.Property<int>("IdPai");

                    b.Property<int>("IdPessoa");

                    b.Property<bool>("MembroProfesso");

                    b.Property<string>("NaturalCidade");

                    b.Property<string>("NaturalEstado");

                    b.Property<string>("NaturalPais");

                    b.Property<string>("Profissao");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.ToTable("PessoaInfoAdicional");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("ConjugueId");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("IdStatusPessoa");

                    b.Property<int?>("InfoAdicionalId");

                    b.Property<bool>("Membro");

                    b.Property<string>("Nome");

                    b.Property<int?>("StatusId");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("ConjugueId")
                        .IsUnique()
                        .HasFilter("[ConjugueId] IS NOT NULL");

                    b.HasIndex("InfoAdicionalId");

                    b.HasIndex("StatusId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaOrgaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int?>("CargoOrgaoId");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<DateTime>("DataFimVigencia");

                    b.Property<int>("IdCargo_Orgao");

                    b.Property<int>("IdOrgao");

                    b.Property<int>("IdPessoa");

                    b.Property<int?>("OrgaoId");

                    b.Property<int?>("PessoaId");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.HasIndex("CargoOrgaoId");

                    b.HasIndex("OrgaoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("PessoaOrgao");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.RegistroPresencaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunoId");

                    b.Property<bool>("Ativo");

                    b.Property<int?>("AulaId");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("IdAluno");

                    b.Property<int>("IdAula");

                    b.Property<bool>("Presente");

                    b.Property<bool>("TrouxeBiblia");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.Property<bool>("Visita");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("AulaId");

                    b.ToTable("RegistroPresenca");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.StatusPessoaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.ToTable("StatusPessoa");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.TemaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Descricao");

                    b.Property<string>("Titulo");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.ToTable("Tema");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.TipoOrgaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<string>("Nome");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.Property<int>("VigenciaAnos");

                    b.HasKey("Id");

                    b.ToTable("TipoOrgao");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.TurmaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("IdadeMaxima");

                    b.Property<int>("IdadeMinima");

                    b.Property<string>("Nome");

                    b.Property<string>("UsuarioAlteracao");

                    b.Property<string>("UsuarioCriacao");

                    b.HasKey("Id");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.AlunoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaModel", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");

                    b.HasOne("Cavalheiro.Ashbel.Model.TurmaModel", "Turma")
                        .WithMany()
                        .HasForeignKey("TurmaId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.AssuntoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.TemaModel", "Tema")
                        .WithMany()
                        .HasForeignKey("TemaId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.CargoOrgaoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.CargoModel", "Cargo")
                        .WithMany()
                        .HasForeignKey("CargoId");

                    b.HasOne("Cavalheiro.Ashbel.Model.OrgaoModel", "Orgao")
                        .WithMany()
                        .HasForeignKey("OrgaoId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.OrgaoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.TipoOrgaoModel", "TipoOrgao")
                        .WithMany()
                        .HasForeignKey("TipoOrgaoId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaContatoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaModel")
                        .WithMany("Contatos")
                        .HasForeignKey("PessoaModelId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaEnderecoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaModel")
                        .WithMany("Enderecos")
                        .HasForeignKey("PessoaModelId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaModel", "Conjugue")
                        .WithOne("Pai")
                        .HasForeignKey("Cavalheiro.Ashbel.Model.PessoaModel", "ConjugueId");

                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaInfoAdicionalModel", "InfoAdicional")
                        .WithMany()
                        .HasForeignKey("InfoAdicionalId");

                    b.HasOne("Cavalheiro.Ashbel.Model.StatusPessoaModel", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.PessoaOrgaoModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.CargoOrgaoModel", "CargoOrgao")
                        .WithMany()
                        .HasForeignKey("CargoOrgaoId");

                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaModel", "Orgao")
                        .WithMany()
                        .HasForeignKey("OrgaoId");

                    b.HasOne("Cavalheiro.Ashbel.Model.PessoaModel", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId");
                });

            modelBuilder.Entity("Cavalheiro.Ashbel.Model.RegistroPresencaModel", b =>
                {
                    b.HasOne("Cavalheiro.Ashbel.Model.AlunoModel", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId");

                    b.HasOne("Cavalheiro.Ashbel.Model.AulaModel", "Aula")
                        .WithMany()
                        .HasForeignKey("AulaId");
                });
#pragma warning restore 612, 618
        }
    }
}
