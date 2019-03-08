using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class AssuntoConfiguration : IEntityTypeConfiguration<AssuntoModel>
    {
        public void Configure(EntityTypeBuilder<AssuntoModel> builder)
        {
            builder.ToTable("Assunto").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.Titulo).IsRequired().HasMaxLength(50).HasColumnName("Titulo");
            builder.Property(t => t.Descricao).IsRequired().HasMaxLength(250).HasColumnName("Descricao");
            builder.Property(t => t.IdTema).IsRequired().HasColumnName("IdTema");

        }
    }
}
