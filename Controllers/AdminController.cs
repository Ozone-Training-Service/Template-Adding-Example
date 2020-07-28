using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TempleteAddingExample.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View11222();
        }

        public IActionResult AddBook()
        {
            return View();
        }


        public IActionResult Book2()
        {


            return PartialView();
        }
    }
}