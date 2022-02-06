using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SwaggerSettingsDemo.Pages;

public class Index_Tests : SwaggerSettingsDemoWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
