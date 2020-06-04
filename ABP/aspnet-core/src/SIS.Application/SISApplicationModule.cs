using Abp.AutoMapper;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SIS.Authorization;
using SIS.Students.StudentInfoServices;

namespace SIS
{
    [DependsOn(
        typeof(SISCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SISApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SISAuthorizationProvider>();

        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SISApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );

            //Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder.For<IStudentInfoAppService>("student/personalInformation").Build();
        }
    }
}
