using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace SuperPowers
{
    [DependsOn(typeof(AbpWebApiModule), typeof(SuperPowersApplicationModule))]
    public class SuperPowersWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(SuperPowersApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
