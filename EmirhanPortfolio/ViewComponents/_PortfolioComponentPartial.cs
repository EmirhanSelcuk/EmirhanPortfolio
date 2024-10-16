using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
