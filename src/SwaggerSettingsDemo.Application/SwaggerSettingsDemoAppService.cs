using System;
using System.Collections.Generic;
using System.Text;
using SwaggerSettingsDemo.Localization;
using Volo.Abp.Application.Services;

namespace SwaggerSettingsDemo;

/* Inherit your application services from this class.
 */
public abstract class SwaggerSettingsDemoAppService : ApplicationService
{
    protected SwaggerSettingsDemoAppService()
    {
        LocalizationResource = typeof(SwaggerSettingsDemoResource);
    }
}
