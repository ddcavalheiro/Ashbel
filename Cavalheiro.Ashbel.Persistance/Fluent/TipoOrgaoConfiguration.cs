using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class TipoOrgaoConfiguration : IEntityTypeConfiguration<TipoOrgaoModel>
    {
        public void Configure(EntityTypeBuilder<TipoOrgaoModel> builder)
        {
            builder.ToTable("TipoOrgao").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(50);
            builder.Property(t => t.VigenciaAnos).HasColumnName("VigenciaAnos").HasColumnType("int");
        }
    }
}
