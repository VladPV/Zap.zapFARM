using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Zap.zapFARM.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Groups()
        {
            return View();
        }

        public IActionResult Devices()
        {
            return View();
        }

        public IActionResult Proxy()
        {
            return View();
        }

        public IActionResult Tools()
        {
            return View();
        }

        public IActionResult Certificates()
        {
            return View();
        }

        public IActionResult Licenses()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
