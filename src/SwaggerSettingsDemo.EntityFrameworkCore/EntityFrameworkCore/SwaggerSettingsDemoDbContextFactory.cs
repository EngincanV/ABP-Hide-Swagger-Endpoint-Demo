using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SwaggerSettingsDemo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SwaggerSettingsDemoDbContextFactory : IDesignTimeDbContextFactory<SwaggerSettingsDemoDbContext>
{
    public SwaggerSettingsDemoDbContext CreateDbContext(string[] args)
    {
        SwaggerSettingsDemoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SwaggerSettingsDemoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SwaggerSettingsDemoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SwaggerSettingsDemo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
