using Escola.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Infra.Data.EntitiesConfiguration
{
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Usuario_ID)
                .IsRequired();
            builder.Property(m => m.Turma_ID)
                .IsRequired();

            builder.HasOne(m => m.Usuario)
                .WithMany(u => u.Matriculas)
                .HasForeignKey(m => m.Usuario_ID)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(m => m.Turma)
                .WithMany(u => u.Matriculas)
                .HasForeignKey(m => m.Turma_ID)
                .OnDelete(DeleteBehavior.NoAction);
            /*
            builder.Property(m => m.DataMatricula)
                .IsRequired()
                .HasColumnType("timestamp with time zone")
                .HasDefaultValueSql("NOW()");

            builder.Property(m => m.DataExpiracao)
                .IsRequired(false)
                .HasColumnType("timestamp with time zone");*/
        }
    }
}
