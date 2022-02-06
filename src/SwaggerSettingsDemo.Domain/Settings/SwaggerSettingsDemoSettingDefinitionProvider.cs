using SwaggerSettingsDemo.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace SwaggerSettingsDemo.Settings;

public class SwaggerSettingsDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        context.Add(new SettingDefinition(
                name: SwaggerSettingConsts.HideEndpoint,
                defaultValue: "false",
                displayName: L("SwaggerHideEndpoints"),
                description: L("SwaggerHideEndpointsDescription"),
                isVisibleToClients: true
            )
        );
    }
    
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SwaggerSettingsDemoResource>(name);
    }
}
