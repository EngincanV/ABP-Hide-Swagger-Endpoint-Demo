using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SwaggerSettingsDemo;

public interface ISwaggerSettingAppService : IApplicationService
{
    Task<string> GetSettingByNameAsync(string name);

    Task UpdateSettingAsync(string name, string value);
}