using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.EntitiesConfiguration
{
    public class NotaConfiguration : IEntityTypeConfiguration<Nota>
    {
        public void Configure(EntityTypeBuilder<Nota> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.Matricula_ID)
                .IsRequired();

            builder.Property(n => n.Valor)
                .HasDefaultValue(0);

            builder.Property(n => n.Aprovado)
                .HasDefaultValue(false);

            builder.HasOne(n => n.Matricula)
                .WithMany(m => m.Notas)
                .HasForeignKey(n => n.Matricula_ID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
