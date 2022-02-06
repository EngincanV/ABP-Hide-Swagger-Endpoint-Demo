using SwaggerSettingsDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SwaggerSettingsDemo;

[DependsOn(
    typeof(SwaggerSettingsDemoEntityFrameworkCoreTestModule)
    )]
public class SwaggerSettingsDemoDomainTestModule : AbpModule
{

}
