using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SIS.EntityFrameworkCore;
using SIS.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SIS.Web.Tests
{
    [DependsOn(
        typeof(SISWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SISWebTestModule : AbpModule
    {
        public SISWebTestModule(SISEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SISWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SISWebMvcModule).Assembly);
        }
    }
}