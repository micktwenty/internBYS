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

            entity.HasOne(x => x.AppUser)
                .WithMany(x => x.AppUserRoles)
                .HasForeignKey(x => x.UserId);


        }
    }
}
