using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class PessoaGrupoTrabalhoConfiguration : IEntityTypeConfiguration<PessoaGrupoTrabalhoModel>
    {
        public void Configure(EntityTypeBuilder<PessoaGrupoTrabalhoModel> builder)
        {
            builder.ToTable("PessoaGrupoTrabalho").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.IdPessoa).IsRequired().HasColumnName("IdPessoa");
            builder.Property(t => t.IdGrupoTrabalho).IsRequired().HasColumnName("IdGrupoTrabalho");
            builder.Property(t => t.IdCargo_GrupoTrabalho).IsRequired().HasColumnName("IdCargo_GrupoTrabalho");
            builder.Property(t => t.DataFimVigencia).IsRequired().HasColumnName("DataFimVigencia");
        }
    }
}
