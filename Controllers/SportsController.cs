using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvocaApp.Data;
using ConvocaApp.Models;
using Microsoft.AspNetCore.Http;

namespace ConvocaApp.Controllers
{
    public class SportsController : Controller
    {
        private readonly ConvocaAppContext _context;

        public SportsController(ConvocaAppContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var deporte = _context.Deportes.ToList<SportsModel>();
            return View(deporte);
        }

        
        // GET: Sports/Details/5
        public IActionResult Details(int id)
        {
            var deporte = _context.Deportes.Find(id);

            if (deporte != null)
                return View(deporte);
            else
                return NotFound();            
        }

        
        // GET: Sports/Create
        public IActionResult Create()
        {
            return View();
        }
                
        // POST: Sports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SportsModel deporte)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Deportes.Add(deporte);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        // GET: Sports/Edit/5
        public IActionResult Edit(int id)
        {
            var deporte = _context.Deportes.Find(id);
            if (deporte != null)
                return View(deporte);
            else
                return NotFound();

        }
        
        // POST: Sports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, SportsModel datosUpdate)
        {
            try
            {
                var deporte = _context.Deportes.Find(id);

                if (deporte != null)
                {
                    deporte.name = datosUpdate.name;
                    deporte.playerNumber = datosUpdate.playerNumber;
                    deporte.accesories = datosUpdate.accesories;
                    deporte.Id = datosUpdate.Id;                    
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
        
        // GET: Sports/Delete/5
        public IActionResult Delete(int id)
        {
            var deporte = _context.Deportes.Find(id);
            if (deporte != null)
                return View(deporte);
            else
                return NotFound();
        }
        
        // POST: Sports/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var deporte = _context.Deportes.Find(id);
                if (deporte != null)
                {
                    _context.Deportes.Remove(deporte);
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
