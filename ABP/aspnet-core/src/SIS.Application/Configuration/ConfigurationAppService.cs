using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SIS.Configuration.Dto;

namespace SIS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SISAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
