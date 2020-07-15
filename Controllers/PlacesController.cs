using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvocaApp.Data;
using ConvocaApp.Models;
using Microsoft.AspNetCore.Http;
using SQLitePCL;

namespace ConvocaApp.Controllers
{
    public class PlacesController : Controller
    {
        private readonly ConvocaAppContext _context;

        public PlacesController(ConvocaAppContext context)
        {
            _context = context;
        }

        // GET: Places
        public IActionResult Index()
        {
            var placesModel = _context.Lugares.ToList<PlacesModel>();
            return View(placesModel);
        }

        // GET: Places/Details/5
        public IActionResult Details(int id)
        {
            var placesModel = _context.Lugares.Find(id);

            if (placesModel != null)
                return View(placesModel);
            else
                return NotFound();
        }
        
        // GET: Places/Create
        public IActionResult Create()
        {
            return View();
        }
        
        // POST: Places/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PlacesModel placesModel)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Lugares.Add(placesModel);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Places/Edit/5
        public IActionResult Edit(int id)
        {
            var eventsModel = _context.Lugares.Find(id);
            if (eventsModel != null)
                return View(eventsModel);
            else
                return NotFound();

        }

        // POST: Places/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,PlacesModel datosUpdate)
        {
            try
            {
                var placesModel = _context.Lugares.Find(id);

                if (placesModel != null)
                {
                    placesModel.name = datosUpdate.name;
                    placesModel.address = datosUpdate.address;
                    placesModel.email = datosUpdate.email;
                    placesModel.cellphone = datosUpdate.cellphone;
                    placesModel.Id = datosUpdate.Id;                    
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

        // GET: Places/Delete/5
        public IActionResult Delete(int id)
        {
            var placesModel = _context.Lugares.Find(id);
            if (placesModel != null)
                return View(placesModel);
            else
                return NotFound();
        }


        // POST: Places/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var placesModel = _context.Lugares.Find(id);
                if (placesModel != null)
                {
                    _context.Lugares.Remove(placesModel);
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
