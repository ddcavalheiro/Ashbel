using Cavalheiro.Ashbel.Model;
using Cavalheiro.Ashbel.Persistance.Fluent;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cavalheiro.Ashbel.Persistance
{
    public class AshbelDbContext : DbContext
    {
        public AshbelDbContext(DbContextOptions<AshbelDbContext> options)
            : base(options)
        { }
        public DbSet<AlunoModel> Aluno { get; set; }
        public DbSet<AssuntoModel> Assunto { get; set; }
        public DbSet<AulaModel> Aula { get; set; }

        public DbSet<CargoModel> Cargo { get; set; }
        public DbSet<CargoGrupoTrabalhoModel> CargoGrupoTrabalho { get; set; }

        public DbSet<GrupoTrabalhoModel> GrupoTrabalho { get; set; }

        public DbSet<PessoaModel> Pessoa { get; set; }
        public DbSet<PessoaContatoModel> PessoaContato { get; set; }
        public DbSet<PessoaEnderecoModel> PessoaEndereco { get; set; }
        public DbSet<PessoaInfoAdicionalModel> PessoaInfoAdicional { get; set; }
        public DbSet<PessoaGrupoTrabalhoModel> PessoaGrupoTrabalho { get; set; }

        public DbSet<RegistroPresencaModel> RegistroPresenca { get; set; }

        public DbSet<StatusPessoaModel> StatusPessoa { get; set; }

        public DbSet<TemaModel> Tema { get; set; }
        public DbSet<TipoGrupoTrabalhoModel> TipoGrupoTrabalho { get; set; }

        public DbSet<TurmaModel> Turma { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
        }
    }


}