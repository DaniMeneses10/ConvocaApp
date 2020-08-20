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
            //ViewBag.CosaDinamica = "Es para probar y Llamar cosas";
            //ViewBag.FechaActual = System.DateTime.Today;
            return View();

        }


        public IActionResult Convoca()
        {
            var d1 = new ConvocaModel();
                d1.Deporte = "Futbol";
                d1.Lugar = "Cedritos";
                d1.Jugadores = "10";

            return View(d1);
        }
    }
}
