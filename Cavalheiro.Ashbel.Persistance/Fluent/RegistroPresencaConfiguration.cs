using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class RegistroPresencaConfiguration : IEntityTypeConfiguration<RegistroPresencaModel>
    {
        public void Configure(EntityTypeBuilder<RegistroPresencaModel> builder)
        {
            builder.ToTable("RegistroPresenca").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.IdAula).IsRequired().HasColumnName("IdAula");
            builder.Property(t => t.IdAluno).IsRequired().HasColumnName("IdAluno");
            builder.Property(t => t.TrouxeBiblia).IsRequired().HasColumnName("TrouxeBiblia").HasColumnType("bit").HasDefaultValue(true);
            builder.Property(t => t.Presente).IsRequired().HasColumnName("Presente").HasColumnType("bit").HasDefaultValue(true);
            builder.Property(t => t.Visita).IsRequired().HasColumnName("Visita").HasColumnType("bit").HasDefaultValue(false);
        }
    }
}
