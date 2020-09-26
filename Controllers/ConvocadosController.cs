using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvocaApp.Data;
using ConvocaApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace ConvocaApp.Controllers
{
    [Authorize]
    public class ConvocadosController : Controller
    {
        private readonly ConvocaAppContext _context;

        public ConvocadosController(ConvocaAppContext context)
        {
            _context = context;
        }

        // GET: Convocados
        public async Task<IActionResult> Index()
        {
            var convocadosModel = _context.Convocados.ToList<ConvocadosModel>();
            return View(await _context.Convocados.ToListAsync());
        }




        // GET: Convocados/Details/5
        public IActionResult Details(int? id)
        {
            var convocadosModel = _context.Convocados.Find(id);

            if (convocadosModel != null)
                return View(convocadosModel);
            else
                return NotFound();
        }

        [Authorize]
        // GET: Convocados/Create
        public IActionResult Create(int id)
        {
            ConvocadosModel convocados = new ConvocadosModel();
            return View();

            //return View();
        }


        // POST: Convocados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [Authorize]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        
        public JsonResult Create(ConvocadosModel convocados)
        //public IActionResult Create(ConvocadosModel convocados)
        {
            var dataLogin = new loginOkModel();

            try
            {
                var convocadosEvento = new ConvocadosModel();

                convocadosEvento.event_id = convocados.Id;

                var UserIdLogueado = User.Claims.FirstOrDefault(c => c.Type == "UserId");

                var UserIdLogueado1 = Convert.ToInt32(UserIdLogueado.Value);

                convocadosEvento.user_id = UserIdLogueado1;

                // TODO: Add insert logic here
                _context.Convocados.Add(convocadosEvento);
                _context.SaveChanges();

                dataLogin.ok = true;
                //return RedirectToAction(nameof(Index));
                ////return RedirectToAction("Index", "Events", new { id = "AllEvents" });
            }
            catch
            {
                dataLogin.ok = false;
                //return View();
            }
            return (Json(dataLogin));
            //return RedirectToAction("Index", "Events", new { id = "AllEvents" });
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(ConvocadosModel convocados)
        //{
        //    try
        //    {
        //        var convocadosEvento = new ConvocadosModel();

        //        convocadosEvento.event_id = convocados.Id;

        //        var UserIdLogueado = User.Claims.FirstOrDefault(c => c.Type == "UserId");

        //        var UserIdLogueado1 = Convert.ToInt32(UserIdLogueado.Value);

        //        convocadosEvento.user_id = UserIdLogueado1;


        //        // TODO: Add insert logic here
        //        _context.Convocados.Add(convocadosEvento);
        //        _context.SaveChanges();

        //        //return RedirectToAction(nameof(Index));
        //        return RedirectToAction("Index", "Events", new { id = "AllEvents" });
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        // GET: Convocados/Edit/5
        public IActionResult Edit(int? id)
        {
            var convocadosModel = _context.Convocados.Find(id);
            if (convocadosModel != null)
                return View(convocadosModel);
            else
                return NotFound();

        }

        // POST: Convocados/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("event_id,user_id,Id")] ConvocadosModel datosUpdate)
        {
            try
            {
                var convocadosModel = _context.Convocados.Find(id);

                if (convocadosModel != null)
                {
                    convocadosModel.event_id = datosUpdate.event_id;
                    convocadosModel.user_id = datosUpdate.user_id;
                    convocadosModel.Id = datosUpdate.Id;
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return NotFound();

                // TODO: Add update logic here                
            }
            catch
            {
                return View();
            }
        }

        // GET: Convocados/Delete/5
        public IActionResult Delete(int? id)
        {
            var convocadosModel = _context.Convocados.Find(id);
            if (convocadosModel != null)
                return View(convocadosModel);
            else
                return NotFound();
        }

        // POST: Convocados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var convocadosModel = _context.Convocados.Find(id);
                if (convocadosModel != null)
                {
                    _context.Convocados.Remove(convocadosModel);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                else
                    return NotFound();
                // TODO: Add delete logic here                                
            }
            catch
            {
                return View();
            }
        }
    }
}
