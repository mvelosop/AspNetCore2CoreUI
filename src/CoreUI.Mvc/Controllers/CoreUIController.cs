using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreUI.Mvc.Controllers
{
    [Route("CoreUI")]
    public class CoreUIController : Controller
    {
        [Route("{view=Index}")]
        public IActionResult Index(string view)
        {
            ViewData["Title"] = "CoreUI Free Bootstrap Admin Template";

            return View(view);
        }
        [Route("{subroute}/{view=Index}")]
        public IActionResult Subroute(string subroute, string view)
        {
            ViewData["Title"] = "CoreUI Free Bootstrap Admin Template";

            return View($"{subroute}/{view}");
        }
    }
}