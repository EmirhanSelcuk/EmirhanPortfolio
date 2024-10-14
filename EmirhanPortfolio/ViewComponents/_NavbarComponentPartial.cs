using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
