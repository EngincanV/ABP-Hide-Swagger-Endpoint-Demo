using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerSettingsDemo.Web.Models;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Widgets;
using Volo.Abp.Settings;

namespace SwaggerSettingsDemo.Web.Components.SwaggerHideEndpoints;

[Widget(ScriptFiles = new []{ "/Components/SwaggerHideEndpoints/Default.js" })]
public class SwaggerHideEndpointsViewComponent : AbpViewComponent
{
    private readonly ISwaggerSettingAppService _swaggerSettingAppService;

    public SwaggerHideEndpointsViewComponent(ISwaggerSettingAppService swaggerSettingAppService)
    {
        _swaggerSettingAppService = swaggerSettingAppService;
    }


    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var swaggerHideEndpointSetting = await _swaggerSettingAppService.GetSettingByNameAsync(SwaggerSettingConsts.HideEndpoint);

        return View("~/Components/SwaggerHideEndpoints/Default.cshtml", new SwaggerHideEndpointViewModel
        {
            HideEndpoints = !string.IsNullOrEmpty(swaggerHideEndpointSetting) && 
                            bool.TryParse(swaggerHideEndpointSetting, out var hideEndpoints) && hideEndpoints
        });
    }
}