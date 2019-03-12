using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class PessoaContatoConfiguration : IEntityTypeConfiguration<PessoaContatoModel>
    {
        public void Configure(EntityTypeBuilder<PessoaContatoModel> builder)
        {
            builder.ToTable("PessoaContato").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.TelefoneCelular).HasColumnName("TelefoneCelular").HasMaxLength(15);
            builder.Property(t => t.TelefoneFixo).HasColumnName("TelefoneFixo").HasMaxLength(15);
            builder.Property(t => t.EmailPrincipal).HasColumnName("EmailPrincipal").HasMaxLength(50);
            builder.Property(t => t.EmailSecundario).HasColumnName("EmailSecundario").HasMaxLength(50);

            builder.Property(t => t.IdPessoa).IsRequired().HasColumnName("IdPessoa");

            builder.HasOne(p => p.Pessoa)
                .WithMany(c => c.Contatos)
                .HasForeignKey(f => f.IdPessoa)
                .HasConstraintName("FK_Pessoa_Contatos");
        }
    }
}
