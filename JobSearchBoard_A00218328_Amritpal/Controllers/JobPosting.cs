using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchBoard_A00218328_Amritpal.Controllers
{
    public class JobPosting : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
