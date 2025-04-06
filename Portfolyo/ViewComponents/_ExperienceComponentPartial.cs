using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;
namespace Portfolyo.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        PortfolyoContext context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
