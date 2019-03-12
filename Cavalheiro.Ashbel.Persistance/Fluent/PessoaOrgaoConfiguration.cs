using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class PessoaOrgaoConfiguration : IEntityTypeConfiguration<PessoaOrgaoModel>
    {
        public void Configure(EntityTypeBuilder<PessoaOrgaoModel> builder)
        {
            builder.ToTable("PessoaOrgao").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.IdPessoa).IsRequired().HasColumnName("IdPessoa");
            builder.Property(t => t.IdOrgao).IsRequired().HasColumnName("IdOrgao");
            builder.Property(t => t.IdCargo_Orgao).IsRequired().HasColumnName("IdCargo_Orgao");
            builder.Property(t => t.DataFimVigencia).IsRequired().HasColumnName("DataFimVigencia");
        }
    }
}
