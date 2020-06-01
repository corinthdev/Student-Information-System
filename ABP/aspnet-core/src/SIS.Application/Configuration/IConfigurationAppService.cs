using System.Threading.Tasks;
using SIS.Configuration.Dto;

namespace SIS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
