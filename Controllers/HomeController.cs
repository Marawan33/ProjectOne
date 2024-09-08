using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult Index()
        {

            return Content("Hello from ContentResult");
        }
    }
}
