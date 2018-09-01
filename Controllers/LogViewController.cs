using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core.log.viewer.Models;

namespace core.log.viewer.Controllers
{
    public class LogView : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
