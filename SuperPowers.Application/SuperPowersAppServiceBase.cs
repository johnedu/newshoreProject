using Abp.Application.Services;

namespace SuperPowers
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class SuperPowersAppServiceBase : ApplicationService
    {
        protected SuperPowersAppServiceBase()
        {
            LocalizationSourceName = SuperPowersConsts.LocalizationSourceName;
        }
    }
}