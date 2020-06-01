using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SIS.Authorization;

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
        }
    }
}
