using Abp.Web.Mvc.Controllers;

namespace SuperPowers.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class SuperPowersControllerBase : AbpController
    {
        protected SuperPowersControllerBase()
        {
            LocalizationSourceName = SuperPowersConsts.LocalizationSourceName;
        }
    }
}