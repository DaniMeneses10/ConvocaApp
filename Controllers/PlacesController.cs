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
            var lugares = _context.Lugares.ToList<PlacesModel>();
            return View(lugares);
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
        public IActionResult Create(PlacesViewModel lugar)
        {
            try
            {
                var lugarDB = new PlacesModel();

                lugarDB.name = lugar.name;
                lugarDB.email = lugar.email;
                lugarDB.cellphone = lugar.cellphone;
                lugarDB.Id = lugar.Id;
                lugarDB.addressStreet = lugar.addressStreet;
                lugarDB.addressNumber1 = lugar.addressNumber1;
                lugarDB.addressNumber2 = lugar.addressNumber2;
                lugarDB.addressNumber3 = lugar.addressNumber3;
                lugarDB.addressLocation = lugar.addressLocation;
                lugarDB.address = lugar.addressStreet + " " + lugar.addressNumber1 + " # " + lugar.addressNumber2 + " - " + lugar.addressNumber3 + " " + lugar.addressLocation;
                //TODO: Add insert logic here
                _context.Lugares.Add(lugarDB);
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
            var placesModel = _context.Lugares.Find(id);
            if (placesModel != null)
                return View(placesModel);
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
                var lugarDB = _context.Lugares.Find(id);

                if (lugarDB != null)
                {
                    lugarDB.name = datosUpdate.name;
                    lugarDB.email = datosUpdate.email;
                    lugarDB.cellphone = datosUpdate.cellphone;
                    lugarDB.Id = datosUpdate.Id;
                    lugarDB.addressStreet = datosUpdate.addressStreet;
                    lugarDB.addressNumber1 = datosUpdate.addressNumber1;
                    lugarDB.addressNumber2 = datosUpdate.addressNumber2;
                    lugarDB.addressNumber3 = datosUpdate.addressNumber3;
                    lugarDB.addressLocation = datosUpdate.addressLocation;
                    datosUpdate.address = datosUpdate.addressStreet + " " + datosUpdate.addressNumber1 + " # " + datosUpdate.addressNumber2 + " - " + datosUpdate.addressNumber3 + " " + datosUpdate.addressLocation;
                    //userDB.address = userDB.addressStreet + " " + userDB.addressNumber1 + " # " + userDB.addressNumber2 + " - " + userDB.addressNumber3 + " " + userDB.addressLocation;
                    lugarDB.address = datosUpdate.address;
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
