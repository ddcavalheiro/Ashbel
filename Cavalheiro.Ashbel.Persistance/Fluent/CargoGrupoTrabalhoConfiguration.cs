using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class CargoGrupoTrabalhoConfiguration : IEntityTypeConfiguration<CargoGrupoTrabalhoModel>
    {
        public void Configure(EntityTypeBuilder<CargoGrupoTrabalhoModel> builder)
        {
            builder.ToTable("CargoGrupoTrabalho").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.IdCargo).IsRequired().HasColumnName("IdCargo");
            builder.Property(t => t.IdGrupoTrabalho).IsRequired().HasColumnName("IdGrupoTrabalho");

            builder.HasKey(t => new { t.IdCargo, t.IdGrupoTrabalho });

            builder.HasOne(pt => pt.Cargo)
                .WithMany(p => p.CargoGrupoTrabalhos)
                .HasForeignKey(pt => pt.IdCargo);

            builder.HasOne(pt => pt.GrupoTrabalho)
                .WithMany(t => t.GrupoTrabalhoCargos)
                .HasForeignKey(pt => pt.IdGrupoTrabalho);
        }

    }
}
