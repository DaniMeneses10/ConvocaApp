using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ConvocaApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using ConvocaApp.Models;
using System.Collections;
//using AspNetCore;

namespace ConvocaApp.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        private readonly ConvocaAppContext _context;
        public CuentaController(ConvocaAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var a = User;
            var UserIdLogueado = User.Claims.FirstOrDefault(c => c.Type == "UserId");

            var UserIdLogueado1 = Convert.ToInt32(UserIdLogueado.Value);

            var usuario = _context.Usuarios.Where(x => x.Id == UserIdLogueado1).FirstOrDefault();
          

            var userdetails = new CuentaModel(usuario);
                userdetails.name = usuario.name;
                userdetails.age = usuario.age;
                userdetails.email = usuario.email;
                userdetails.sex = usuario.sex;
                userdetails.password = usuario.password;
                userdetails.cellphone = usuario.cellphone;
                userdetails.Id = usuario.Id;
                userdetails.country = usuario.country;
                userdetails.city = usuario.city;
                userdetails.addressStreet = usuario.addressStreet;
                userdetails.addressNumber1 = usuario.addressNumber1;
                userdetails.addressNumber2 = usuario.addressNumber2;
                userdetails.addressNumber3 = usuario.addressNumber3;
                userdetails.addressLocation = usuario.addressLocation;
                userdetails.address = usuario.addressStreet + " " + usuario.addressNumber1 + " # " + usuario.addressNumber2 + " - " + usuario.addressNumber3 + " " + usuario.addressLocation;

            return View(userdetails);

            //return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Ciudades = _context.Ciudades.ToList();//DB
            //var usuario = _context.Usuarios.Find(id).ToList<UsersViewModel>();
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)

                return View(usuario);
            else
                return NotFound();

        }

        // POST: User/Edit/5       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CuentaModel datosUpdate)
        {
            try
            {
                var userDB = _context.Usuarios.Find(id);

                if (userDB != null)
                {

                    userDB.name = datosUpdate.name;
                    userDB.age = datosUpdate.age;
                    userDB.email = datosUpdate.email;
                    userDB.sex = datosUpdate.sex;
                    userDB.password = datosUpdate.password;
                    userDB.cellphone = datosUpdate.cellphone;
                    userDB.Id = datosUpdate.Id;
                    userDB.country = datosUpdate.country;
                    userDB.city = datosUpdate.city;
                    userDB.addressStreet = datosUpdate.addressStreet;
                    userDB.addressNumber1 = datosUpdate.addressNumber1;
                    userDB.addressNumber2 = datosUpdate.addressNumber2;
                    userDB.addressNumber3 = datosUpdate.addressNumber3;
                    userDB.addressLocation = datosUpdate.addressLocation;
                    datosUpdate.address = datosUpdate.addressStreet + " " + datosUpdate.addressNumber1 + " # " + datosUpdate.addressNumber2 + " - " + datosUpdate.addressNumber3 + " " + datosUpdate.addressLocation;
                    //userDB.address = userDB.addressStreet + " " + userDB.addressNumber1 + " # " + userDB.addressNumber2 + " - " + userDB.addressNumber3 + " " + userDB.addressLocation;
                    userDB.address = datosUpdate.address;

                    // TODO: Add insert logic here
                    //_context.Usuarios.Add(userDB);
                    _context.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                else
                    return NotFound();
            }
            catch
            {
                return View();
            }
        }
    }
}



