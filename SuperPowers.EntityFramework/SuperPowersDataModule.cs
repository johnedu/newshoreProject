using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using SuperPowers.EntityFramework;

namespace SuperPowers
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(SuperPowersCoreModule))]
    public class SuperPowersDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<SuperPowersDbContext>(null);
        }
    }
}
