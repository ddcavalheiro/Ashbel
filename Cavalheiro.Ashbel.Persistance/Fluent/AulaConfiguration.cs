using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class AulaConfiguration : IEntityTypeConfiguration<AulaModel>
    {
        public void Configure(EntityTypeBuilder<AulaModel> builder)
        {
            builder.ToTable("Aula").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.Ano).IsRequired().HasColumnName("Ano").HasColumnType("int");
            builder.Property(t => t.Mes).IsRequired().HasColumnName("Mes").HasColumnType("int");
            builder.Property(t => t.Dia).IsRequired().HasColumnName("Dia").HasColumnType("int");
        }
    }
}
