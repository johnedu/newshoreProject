using Abp.Web.Mvc.Views;

namespace SuperPowers.Web.Views
{
    public abstract class SuperPowersWebViewPageBase : SuperPowersWebViewPageBase<dynamic>
    {

    }

    public abstract class SuperPowersWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SuperPowersWebViewPageBase()
        {
            LocalizationSourceName = SuperPowersConsts.LocalizationSourceName;
        }
    }
}