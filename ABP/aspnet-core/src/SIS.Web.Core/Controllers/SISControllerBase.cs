using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SIS.Controllers
{
    public abstract class SISControllerBase: AbpController
    {
        protected SISControllerBase()
        {
            LocalizationSourceName = SISConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
