using System.Linq;
using System.Web.Mvc;
using BusinessServices;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductServices _productServices;

        public HomeController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        public ActionResult Index()
        {
            ViewBag.Title = _productServices.GetAllProducts().ToArray()[0].ProductName;

            //ViewBag.Title = "Home Page";

            return View();
        }
    }
}
