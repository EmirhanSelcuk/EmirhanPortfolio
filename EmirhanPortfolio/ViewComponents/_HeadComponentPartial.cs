using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
