using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SwaggerSettingsDemo.Data;

/* This is used if database provider does't define
 * ISwaggerSettingsDemoDbSchemaMigrator implementation.
 */
public class NullSwaggerSettingsDemoDbSchemaMigrator : ISwaggerSettingsDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
