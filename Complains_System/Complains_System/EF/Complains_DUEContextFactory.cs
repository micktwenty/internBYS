using Complains_System.Constants;
using Complains_System.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Models
{
    public class Complains_DUEContextFactory : IDesignTimeDbContextFactory<ComplainsDbContext>
    {
        public ComplainsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString(SystemConstants.MainConnectionString);

            var optionsBuilder = new DbContextOptionsBuilder<ComplainsDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ComplainsDbContext(optionsBuilder.Options);
        }
    }
}
