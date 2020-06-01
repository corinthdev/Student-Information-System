using System.Threading.Tasks;
using Abp.Application.Services;
using SIS.Authorization.Accounts.Dto;

namespace SIS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
