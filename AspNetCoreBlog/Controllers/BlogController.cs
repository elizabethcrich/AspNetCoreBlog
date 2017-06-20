using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBlog.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet("/Blog")]
        public IActionResult Index()
        {
            return View();
        }
    }
}