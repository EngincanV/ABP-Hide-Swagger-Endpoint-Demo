using Volo.Abp.Modularity;

namespace SwaggerSettingsDemo;

[DependsOn(
    typeof(SwaggerSettingsDemoApplicationModule),
    typeof(SwaggerSettingsDemoDomainTestModule)
    )]
public class SwaggerSettingsDemoApplicationTestModule : AbpModule
{

}
