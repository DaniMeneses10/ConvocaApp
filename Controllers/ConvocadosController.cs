﻿using System;
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

namespace ConvocaApp.Controllers
{
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

        // GET: Convocados/Create
        public IActionResult Create(int id)
        {
            return View();
        }


        // POST: Convocados/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ConvocadosModel convocados)
        {
            try
            {
                var convocadosEvento = new ConvocadosModel();

                convocadosEvento.event_id = convocados.Id;


                convocadosEvento.user_id = convocados.user_id;

                // TODO: Add insert logic here
                _context.Convocados.Add(convocadosEvento);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }








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
