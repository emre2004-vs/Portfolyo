﻿using Microsoft.AspNetCore.Mvc;
namespace Portfolyo.ViewComponents._LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
