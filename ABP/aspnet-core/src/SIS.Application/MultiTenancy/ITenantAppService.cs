using Abp.Application.Services;
using SIS.MultiTenancy.Dto;

namespace SIS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

