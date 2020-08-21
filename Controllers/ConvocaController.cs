using ConvocaApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvocaApp.Controllers
{
    public class ConvocaController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }


        public IActionResult Convoca()
        {
            return View();
        }

        public IActionResult StartApp()
        {
            var a = User;
            var UserIdLogueado = User.Claims.FirstOrDefault(c => c.Type == "UserId");
            //var UserIdLogueado1 = Convert.ToInt32(UserIdLogueado.Value);

            if (UserIdLogueado != null)
            {
                return RedirectToAction("Index", "Convoca");
            }
            else
            {
                return RedirectToAction("Convoca", "Convoca");
            }
        }
    }
}
