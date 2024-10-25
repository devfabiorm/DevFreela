using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DevFreela.Infrastructure.Persistence.Migrations
{
    public static class DataMigration
    {
        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<DevFreelaDbContext>();

            dbContext.Database.Migrate();
        }
    }
}
