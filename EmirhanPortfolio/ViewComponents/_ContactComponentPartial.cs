using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
