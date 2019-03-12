using Cavalheiro.Ashbel.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cavalheiro.Ashbel.Persistance.Fluent
{
    public class PessoaEnderecoConfiguration : IEntityTypeConfiguration<PessoaEnderecoModel>
    {
        public void Configure(EntityTypeBuilder<PessoaEnderecoModel> builder)
        {
            builder.ToTable("PessoaEndereco").HasKey(o => o.Id).HasName("Id");
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd().IsRequired();
            builder.Property(t => t.DataCriacao).IsRequired().HasColumnName("DataCriacao");
            builder.Property(t => t.UsuarioCriacao).IsRequired().HasColumnName("UsuarioCriacao");
            builder.Property(t => t.DataAlteracao).HasColumnName("DataAlteracao");
            builder.Property(t => t.UsuarioAlteracao).HasColumnName("UsuarioAlteracao");

            builder.Property(t => t.IdPessoa).IsRequired().HasColumnName("IdPessoa");
            builder.Property(t => t.Logradouro).IsRequired().HasColumnName("Logradouro");
            builder.Property(t => t.Numero).HasColumnName("Numero");
            builder.Property(t => t.Complemento).HasColumnName("Complemento");
            builder.Property(t => t.CEP).HasColumnName("CEP");
            builder.Property(t => t.Bairro).HasColumnName("Bairro");
            builder.Property(t => t.Cidade).HasColumnName("Cidade");
            builder.Property(t => t.Estado).HasColumnName("Estado");

            builder.HasOne(p => p.Pessoa)
                .WithMany(e => e.Enderecos)
                .HasForeignKey(f => f.IdPessoa)
                .HasConstraintName("FK_Pessoa_PessoaEndereco");
        }
    }
}
