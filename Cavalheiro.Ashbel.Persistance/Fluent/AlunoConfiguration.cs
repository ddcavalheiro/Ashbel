using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class AlunoConfiguration : IEntityTypeConfiguration<AlunoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            //base class properties
            builder.ToTable("Aluno").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            //class properties
            builder.Property(t => t.Matriculado).IsRequired().HasDefaultValue(true).HasColumnName("Matriculado");

            //relation properties
            builder.Property(t => t.IdPessoa).IsRequired().HasDefaultValue(0).HasColumnName("IdPessoa");
            builder.Property(t => t.IdTurma).IsRequired().HasMaxLength(250).HasColumnName("IdTurma");

            //Relations

            builder.HasOne(s => s.Pessoa)
                    .WithOne(ad => ad.Aluno)
                    .HasConstraintName("FK_Aluno_Pessoa");

            builder.HasOne(s => s.Turma)
                    .WithMany(ad => ad.Alunos)
                    .HasForeignKey(ad => ad.IdTurma)
                    .HasConstraintName("FK_Turma_Alunos");

        }
    }
}
