using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using ConvocaApp.Data;
using ConvocaApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace ConvocaApp.Controllers
{
    public class UsersController : Controller
    {
        /*_context es el objeto que permite conectarse a la DB de manera 
         * bidireccional, lo que significa que puede llevar y traer datos*/
        private readonly ConvocaAppContext _context;

        public UsersController(ConvocaAppContext context)
        {
            _context = context;
        }
        
        
        public ActionResult Index()
        {
            var usuarios = _context.Usuarios.ToList<UsersModel>();
            return View(usuarios);
        }

        
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario != null)
                return View(usuario);
            else
                return NotFound();
        }

        
        // GET: User/Create
        public ActionResult Create()
        {
            ViewBag.Ciudades = _context.Ciudades.ToList();//DB
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsersModel usuario)
        {
            try
            {
                // TODO: Add insert logic here
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Ciudades = _context.Ciudades.ToList();//DB
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
                return View(usuario);
            else
                return NotFound();

        }

        

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UsersModel datosUpdate)
        {
            try
            {
                var usuario = _context.Usuarios.Find(id);

                if (usuario != null)
                {
                    usuario.name = datosUpdate.name;
                    usuario.age = datosUpdate.age;
                    usuario.email = datosUpdate.email;
                    usuario.sex = datosUpdate.sex;
                    usuario.address = datosUpdate.address;
                    //usuario.addressStreet = datosUpdate.addressStreet;
                    //usuario.addressNumber = datosUpdate.addressNumber;
                    //usuario.addressNumber2 = datosUpdate.addressNumber2;
                    usuario.password = datosUpdate.password;
                    usuario.cellphone = datosUpdate.cellphone;
                    usuario.country = datosUpdate.country;
                    usuario.city = datosUpdate.city;
                    usuario.Id = datosUpdate.Id;
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

        
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
                return View(usuario);
            else
                return NotFound();
        }

        
        // POST: User/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var usuario = _context.Usuarios.Find(id);
                if (usuario != null)
                {
                    _context.Usuarios.Remove(usuario);
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