using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SwaggerSettingsDemo.Web;

[Dependency(ReplaceServices = true)]
public class SwaggerSettingsDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SwaggerSettingsDemo";
}
