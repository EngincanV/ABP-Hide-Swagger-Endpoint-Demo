using System.Threading.Tasks;
using Volo.Abp.SettingManagement;
using Volo.Abp.Settings;

namespace SwaggerSettingsDemo;

public class SwaggerSettingAppService : SwaggerSettingsDemoAppService, ISwaggerSettingAppService
{
    private readonly ISettingProvider _settingProvider;
    private readonly ISettingManager _settingManager;

    public SwaggerSettingAppService(ISettingProvider settingProvider, ISettingManager settingManager)
    {
        _settingProvider = settingProvider;
        _settingManager = settingManager;
    }
    
    public async Task<string> GetSettingByNameAsync(string name)
    {
        return await _settingProvider.GetOrNullAsync(name);
    }

    public async Task UpdateSettingAsync(string name, string value)
    {
        await _settingManager.SetGlobalAsync(name, value);
    }
}