using System.Linq;
using System.Web.Mvc;
using Restaurant.Repository;

namespace Resturant.Web.Controllers
{
    public class HomeController : Controller
    {
        public RestaurantContext dbContext;

        public HomeController()
        {
            dbContext = new RestaurantContext();
        }

        public ActionResult Index()
        {
            var test = dbContext.Orders.Select(x => x.Id);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}