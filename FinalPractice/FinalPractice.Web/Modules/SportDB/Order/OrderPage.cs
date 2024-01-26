
namespace FinalPractice.SportDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportDB/Order"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrderRow))]
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportDB/Order/OrderIndex.cshtml");
        }
    }
}