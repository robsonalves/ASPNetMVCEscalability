using System.Data.Entity;
using System.Web.Mvc;
using Restaurant.Entity;
using Restaurant.Repository;

namespace Resturant.Web.Controllers
{
    public class BaseController : Controller
    {
        public RestaurantContext _dbContext;
        public BaseController(RestaurantContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}