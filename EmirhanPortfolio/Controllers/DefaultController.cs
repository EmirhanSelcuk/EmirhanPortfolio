using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
