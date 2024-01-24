
namespace FinalPractice.SportDB.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("SportDB/Product"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ProductRow))]
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/SportDB/Product/ProductIndex.cshtml");
        }
    }
}