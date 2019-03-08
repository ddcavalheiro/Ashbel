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
            builder.Property(t => t.IdStatusPessoa).IsRequired().HasDefaultValue(0).HasColumnName("IdStatusPessoa");
            builder.Property(t => t.Nome).IsRequired().HasMaxLength(250).HasColumnName("Nome");
            builder.Property(t => t.Membro).IsRequired().HasDefaultValue(true).HasColumnName("Membro");

            builder.HasOne<PessoaInfoAdicionalModel>(s => s.InfoAdicional)
                    .WithOne(ad => ad.Pessoa)
                    .HasForeignKey<PessoaInfoAdicionalModel>(ad => ad.IdPessoa);

        }
    }
}
