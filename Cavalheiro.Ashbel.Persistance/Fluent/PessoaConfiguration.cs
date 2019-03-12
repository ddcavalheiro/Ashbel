using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class PessoaConfiguration : IEntityTypeConfiguration<PessoaModel>
    {
        public void Configure(EntityTypeBuilder<PessoaModel> builder)
        {
            builder.ToTable("Pessoa").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.Nome).IsRequired().HasMaxLength(250).HasColumnName("Nome");
            builder.Property(t => t.Membro).IsRequired().HasDefaultValue(true).HasColumnName("Membro");

            builder.Property(t => t.IdStatusPessoa).IsRequired().HasDefaultValue(0).HasColumnName("IdStatusPessoa");
            builder.Property(t => t.IdPessoaPai).IsRequired().HasColumnName("IdPessoaPai");
            builder.Property(t => t.IdPessoaConjugue).IsRequired().HasColumnName("IdPessoaConjugue");

            builder.HasOne(s => s.InfoAdicional)
                .WithOne(ad => ad.Pessoa)
                .HasForeignKey<PessoaModel>(p=> p.IdPessoaInfoAdicional)
                .HasConstraintName("FK_Pessoa_InfoAdicional");

            builder.HasOne(s => s.Pai)
                .WithOne()
                .HasForeignKey<PessoaModel>(p => p.IdPessoaPai)
                .HasConstraintName("FK_Pessoa_PessoaPai");

            builder.HasOne(s => s.Conjugue)
                .WithOne()
                .HasForeignKey<PessoaModel>(p => p.IdPessoaConjugue)
                .HasConstraintName("FK_Pessoa_PessoaConjugue");

            builder.HasOne(c => c.Status)
                .WithMany()
                .HasForeignKey(s => s.IdStatusPessoa)
                .HasConstraintName("FK_Pessoa_StatusPessoa");


        }
    }
}
