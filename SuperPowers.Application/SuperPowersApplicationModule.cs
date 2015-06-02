using System.Reflection;
using Abp.Modules;
using AutoMapper;
using System.Linq;
using System;
using SuperPowers.Utilities.AutoMapper;

namespace SuperPowers
{
    [DependsOn(typeof(SuperPowersCoreModule))]
    public class SuperPowersApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            InitilizeAutoMapper();
        }

        private void InitilizeAutoMapper()
        {
            Mapper.Initialize(x =>
            {
                var profiles = typeof(AutoMapperBaseProfile).Assembly.GetTypes().Where(perfil => perfil.IsSubclassOf(typeof(AutoMapperBaseProfile)));
                foreach (var perfil in profiles)
                {
                    x.AddProfile((AutoMapperBaseProfile)Activator.CreateInstance(perfil));
                }
            });
        }
    }
}