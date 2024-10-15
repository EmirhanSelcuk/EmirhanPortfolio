using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
