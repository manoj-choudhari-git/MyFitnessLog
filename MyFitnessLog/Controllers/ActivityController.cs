using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyFitnessLog.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        

        

        public IActionResult PushUps()
        {
            return View();
        }

        public IActionResult Squats()
        {
            return View();
        }

        public IActionResult SitUps()
        {
            return View();
        }

        public IActionResult PullUps()
        {
            return View();
        }
    }
}