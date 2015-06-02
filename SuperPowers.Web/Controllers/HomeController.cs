using System.Web.Mvc;

namespace SuperPowers.Web.Controllers
{
    public class HomeController : SuperPowersControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}