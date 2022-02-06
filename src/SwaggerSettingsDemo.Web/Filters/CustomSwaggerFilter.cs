using System.Linq;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Volo.Abp.Threading;

namespace SwaggerSettingsDemo.Web.Filters;

public class CustomSwaggerFilter : IDocumentFilter
{
    private readonly ISwaggerSettingAppService _swaggerSettingAppService;

    public CustomSwaggerFilter(ISwaggerSettingAppService swaggerSettingAppService)
    {
        _swaggerSettingAppService = swaggerSettingAppService;
    }

    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        //AsyncHelper.RunSync => runs async method as sync
        var swaggerHideEndpointSetting = AsyncHelper.RunSync(() => _swaggerSettingAppService.GetSettingByNameAsync(SwaggerSettingConsts.HideEndpoint));

        if (string.IsNullOrEmpty(swaggerHideEndpointSetting) || !bool.TryParse(swaggerHideEndpointSetting, out var hideEndpoints) || !hideEndpoints)
        {
            return;
        }
        
        swaggerDoc.Paths
            .Where(x => x.Key.ToLowerInvariant().StartsWith("/api/abp"))
            .ToList()
            .ForEach(x => swaggerDoc.Paths.Remove(x.Key));
    }
}