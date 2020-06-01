using System.Threading.Tasks;
using Abp.Application.Services;
using SIS.Sessions.Dto;

namespace SIS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
