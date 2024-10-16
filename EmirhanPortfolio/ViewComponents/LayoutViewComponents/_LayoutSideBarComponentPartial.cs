using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSideBarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
