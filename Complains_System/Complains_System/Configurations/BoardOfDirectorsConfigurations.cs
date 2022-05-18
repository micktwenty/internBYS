using Complains_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Configurations
{
    public class BoardOfDirectorsConfigurations : IEntityTypeConfiguration<BoardOfDirectors>
    {
        public void Configure(EntityTypeBuilder<BoardOfDirectors> entity)
        {


            entity.Property(e => e.id).HasColumnName("id").ValueGeneratedOnAdd();

            entity.ToTable("Board_of_directorss");

            entity.HasKey(e => e.id);

            entity.Property(e => e.name)
                .HasMaxLength(225)
                .HasColumnName("name")
                .IsUnicode()
                .HasColumnType("nvarchar(225)");

            entity.Property(e => e.email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(256)
                .HasColumnType("varchar(256)");

            entity.Property(e => e.phone)
                .HasMaxLength(11)
                .HasColumnName("phone")
                .HasColumnType("varchar(11)");

        }
    }
}
