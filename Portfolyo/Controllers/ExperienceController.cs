using Microsoft.AspNetCore.Mvc;
using Portfolyo.DAL.Context;
using Portfolyo.DAL.Entities;

namespace Portfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolyoContext portfolyoContext = new PortfolyoContext();
        public IActionResult ExperienceList()
        {
            var values = portfolyoContext.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult CreateExperience(Experience experience)
        {
            portfolyoContext.Experiences.Add(experience);
            portfolyoContext.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
        public IActionResult DeleteExperience(int id)
        {
            var value = portfolyoContext.Experiences.Find(id);
            portfolyoContext.Experiences.Remove(value);
            portfolyoContext.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = portfolyoContext.Experiences.Find(id);
            return View(value);

        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            portfolyoContext.Experiences.Update(experience);
            portfolyoContext.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
    }
}
