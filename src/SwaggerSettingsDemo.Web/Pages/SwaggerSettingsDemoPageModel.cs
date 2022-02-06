using SwaggerSettingsDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SwaggerSettingsDemo.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class SwaggerSettingsDemoPageModel : AbpPageModel
{
    protected SwaggerSettingsDemoPageModel()
    {
        LocalizationResourceType = typeof(SwaggerSettingsDemoResource);
    }
}
