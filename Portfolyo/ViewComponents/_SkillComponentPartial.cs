using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
namespace Portfolyo.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        PortfolyoContext portfolyoContext = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolyoContext.Skills.ToList();
            return View(values);
        }
    }
}
