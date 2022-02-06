using System.Threading.Tasks;

namespace SwaggerSettingsDemo.Data;

public interface ISwaggerSettingsDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
