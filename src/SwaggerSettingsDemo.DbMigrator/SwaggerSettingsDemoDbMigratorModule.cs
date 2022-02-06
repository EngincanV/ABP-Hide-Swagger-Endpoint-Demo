using SwaggerSettingsDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SwaggerSettingsDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SwaggerSettingsDemoEntityFrameworkCoreModule),
    typeof(SwaggerSettingsDemoApplicationContractsModule)
    )]
public class SwaggerSettingsDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
