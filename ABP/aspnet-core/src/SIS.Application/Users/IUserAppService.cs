using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SIS.Roles.Dto;
using SIS.Users.Dto;

namespace SIS.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
