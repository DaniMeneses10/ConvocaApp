using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvocaApp.Data;
using ConvocaApp.Models;

namespace ConvocaApp.Controllers
{
    public class EventsController : Controller
    {
        private readonly ConvocaAppContext _context;

        public EventsController(ConvocaAppContext context)
        {
            _context = context;
        }

        // GET: Events
        public async Task<IActionResult> Index()
        {
            var eventsModel = _context.Eventos.ToList<EventsModel>();
            return View(await _context.Eventos.ToListAsync());
        }

        // GET: Events/Details/5
        public IActionResult Details(int? id)
        {
            var eventsModel = _context.Eventos.Find(id);

            if (eventsModel != null)
                return View(eventsModel);
            else
                return NotFound();
        }


        // GET: Events/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("category,sex,reserve,date,hour,cost,paymment,Id,place_id,sport_id")] EventsModel eventsModel)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Eventos.Add(eventsModel);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Events/Edit/5
        public IActionResult Edit(int? id)
        {
            var eventsModel = _context.Eventos.Find(id);
            if (eventsModel != null)
                return View(eventsModel);
            else
                return NotFound();

        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("category,sex,reserve,date,hour,cost,paymment,Id,place_id,sport_id")] EventsModel datosUpdate)
        {
            try
            {
                var eventsModel = _context.Eventos.Find(id);

                if (eventsModel != null)
                {
                    eventsModel.category = datosUpdate.category;
                    eventsModel.sex = datosUpdate.sex;
                    eventsModel.reserve = datosUpdate.reserve;
                    eventsModel.date = datosUpdate.date;
                    eventsModel.hour = datosUpdate.hour;
                    eventsModel.cost = datosUpdate.cost;
                    eventsModel.paymment = datosUpdate.paymment;
                    eventsModel.Id = datosUpdate.Id;
                    eventsModel.place_id = datosUpdate.place_id;
                    eventsModel.sport_id = datosUpdate.sport_id;
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

        // GET: Events/Delete/5
        public IActionResult Delete(int? id)
        {
            var eventsModel = _context.Eventos.Find(id);
            if (eventsModel != null)
                return View(eventsModel);
            else
                return NotFound();
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var eventsModel = _context.Eventos.Find(id);
                if (eventsModel != null)
                {
                    _context.Eventos.Remove(eventsModel);
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
