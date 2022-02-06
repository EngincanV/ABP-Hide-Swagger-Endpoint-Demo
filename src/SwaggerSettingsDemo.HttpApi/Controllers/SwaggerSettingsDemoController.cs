using SwaggerSettingsDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SwaggerSettingsDemo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SwaggerSettingsDemoController : AbpControllerBase
{
    protected SwaggerSettingsDemoController()
    {
        LocalizationResource = typeof(SwaggerSettingsDemoResource);
    }
}
