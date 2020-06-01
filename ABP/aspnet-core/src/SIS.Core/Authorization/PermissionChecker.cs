using Abp.Authorization;
using SIS.Authorization.Roles;
using SIS.Authorization.Users;

namespace SIS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
