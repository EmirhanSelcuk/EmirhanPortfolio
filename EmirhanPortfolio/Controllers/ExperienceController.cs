using EmirhanPortfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace EmirhanPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperinceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
