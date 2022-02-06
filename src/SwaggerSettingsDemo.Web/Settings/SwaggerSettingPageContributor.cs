using System.Threading.Tasks;
using SwaggerSettingsDemo.Web.Components.SwaggerHideEndpoints;
using Volo.Abp.SettingManagement.Web.Pages.SettingManagement;

namespace SwaggerSettingsDemo.Web.Settings;

public class SwaggerSettingPageContributor : ISettingPageContributor
{
    public Task ConfigureAsync(SettingPageCreationContext context)
    {
        context.Groups.Add(
            new SettingPageGroup(
                "MySwaggerSettingWrapper",
                "Swagger",
                typeof(SwaggerHideEndpointsViewComponent)
            )
        );

        return Task.CompletedTask;
    }

    public Task<bool> CheckPermissionsAsync(SettingPageCreationContext context)
    {
        //we can check a permission in here, but for now just assume the permission is granted.
        return Task.FromResult(true);
    }
}