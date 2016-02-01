using System.Data.Entity;
using System.Web.Mvc;
using Restaurant.Entity;
using Restaurant.Repository;

namespace Resturant.Web.Controllers
{
    public class OrderController : BaseController
    {
        private DbSet<Order> _dbSet;
        public OrderController() : base(new RestaurantContext())
        {
            _dbSet = _dbContext.Orders;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}