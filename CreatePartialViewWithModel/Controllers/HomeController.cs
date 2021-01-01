using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CreatePartialViewWithModel.Models;

namespace CreatePartialViewWithModel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            var users = new List<User>()
            {
                new User(){name="Mark Rockwell",profession="CEO - Consultant",imageLink="https://res.cloudinary.com/mhmd/image/upload/v1570799922/profile-1_dewapk.jpg"},
                new User(){name="Walter White",profession="Web Development",imageLink="https://res.cloudinary.com/mhmd/image/upload/v1570799922/profile-2_ujssbj.jpg"},
                new User(){name="Sarah Jhinson",profession="Marketing",imageLink="https://res.cloudinary.com/mhmd/image/upload/v1570799922/profile-3_ybnq8v.jpg"},
                new User(){name="William Anderson",profession="Content",imageLink="https://res.cloudinary.com/mhmd/image/upload/v1570799924/profile-4_s3fort.jpg"},
            };
            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
