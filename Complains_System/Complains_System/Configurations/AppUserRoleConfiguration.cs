using Complains_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Configurations
{
    public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> entity)
        {
            entity.ToTable("AppUserRoles");

            entity.Property(x => x.username)
                .HasColumnType("nvarchar(450)")
                .HasColumnName("Username")
                .IsRequired();
            entity.HasOne(x => x.AppUser)
                .WithMany(y => y.AppUserRoles)
                .HasForeignKey(z => z.username);
            entity.HasOne(x => x.AppRole)
                .WithMany(y => y.AppUserRole)
                .HasForeignKey(z => z.RoleId);



        }
    }
}
