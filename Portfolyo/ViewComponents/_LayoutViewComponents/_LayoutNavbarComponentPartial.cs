using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
namespace Portfolyo.ViewComponents._LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        PortfolyoContext context = new PortfolyoContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount= context.ToDoLists.Where(x => x.Status == false).Count();
            var values = context.ToDoLists.Where(x => x.Status == false).ToList();
            return View(values);
        }
    }
}
