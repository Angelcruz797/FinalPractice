
namespace FinalPractice.SportDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportDB/Customer"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CustomerRow))]
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportDB/Customer/CustomerIndex.cshtml");
        }
    }
}