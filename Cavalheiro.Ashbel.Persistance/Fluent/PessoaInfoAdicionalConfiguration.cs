using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class PessoaInfoAdicionalConfiguration : IEntityTypeConfiguration<PessoaInfoAdicionalModel>
    {
        public void Configure(EntityTypeBuilder<PessoaInfoAdicionalModel> builder)
        {
            builder.ToTable("PessoaInfoAdicional").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.IdPessoa).IsRequired().HasColumnName("IdPessoa");
            builder.Property(t => t.Profissao).HasColumnName("Profissao");
            builder.Property(t => t.Empresa).HasColumnName("Empresa");
            builder.Property(t => t.Foto).HasColumnName("Foto");
            builder.Property(t => t.NaturalCidade).HasColumnName("NaturalCidade");
            builder.Property(t => t.NaturalEstado).HasColumnName("NaturalEstado");
            builder.Property(t => t.NaturalPais).HasColumnName("NaturalPais");
            builder.Property(t => t.MembroProfesso).HasColumnName("MembroProfesso");
            builder.Property(t => t.Batizado).HasColumnName("Batizado");

        }
    }
}
