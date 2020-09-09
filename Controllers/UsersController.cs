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
using System.Data.SqlClient;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace ConvocaApp.Controllers
{
    public class UsersController : Controller
    {
        /*_context es el objeto que permite conectarse a la DB de manera 
         * bidireccional, lo que significa que puede llevar y traer datos*/
        private readonly ConvocaAppContext _context;

        public UsersController(ConvocaAppContext context)
        {
            //_context = new ConvocaAppContext();
            _context = context;
            
        }

       
        public ActionResult Index()
        { 
            var usuarios = _context.Usuarios.ToList<UsersModel>();
            return View(usuarios);
        }
        ///
 
        ///
        //GET: User/Login
        public ActionResult Login()
        {
            LoginViewModel objLoginModel = new LoginViewModel();
            return View(objLoginModel);
            //return RedirectToAction("Index", "Convoca");
            //return RedirectToAction("Login", "Users");
        }

        //POST: User/Login
        [HttpPost]
        public ActionResult Login(LoginViewModel objLoginModel)
        {
            var usuarios = _context.Usuarios.ToList<UsersModel>();

            var usuario = usuarios.Where(user => user.email == objLoginModel.email && user.password == objLoginModel.password).FirstOrDefault();

            if (usuario == null) 
            {
                ModelState.AddModelError("Error", "Email y Password no coinciden");
                return View();                    
            }
            else 
            {
                var principal = CreatePrincipal(usuario);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                //Session["Email"]
                return RedirectToAction("Index", "Convoca");
            }
        }

        private ClaimsPrincipal CreatePrincipal(UsersModel user)
        {
            var claims = new List<Claim>
            {
                new Claim("UserId", user.Id.ToString()),
                new Claim("UserEmail", user.email)
            };
            var principal = new ClaimsPrincipal();
            principal.AddIdentity(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
            return principal;
        }



        public async Task<ActionResult> Logout()
        {           

            await HttpContext.SignOutAsync();

            //FormsAuthentication.SignOut();
            return RedirectToAction("Convoca", "Convoca");
        }

        public ActionResult TraerEventos()
        {
            var a = _context.Eventos.ToList();

            //FormsAuthentication.SignOut();
            return Json(a);
        }


        ///
        ///
        ///
        ///

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario != null)
                return View(usuario);
            else
                return NotFound();
        }
        ///
        ///
        ///
        ///

        // GET: User/Create
        public ActionResult Create()
        {
            ViewBag.Ciudades = _context.Ciudades.ToList();//DB
            return View();
        }

        // POST: User/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsersViewModel usuario)
            //LO CREO CON USERVIEWMODEL POR EL ADDRESS, PORQUE LO ESTOY CREANDO PARA QUE LO PUEDAN VER
            //DESPUES EN EL EDIT
        {
            try
            {
                var userDB = new UsersModel();

                userDB.name = usuario.name;
                userDB.age = usuario.age;
                userDB.email = usuario.email;
                userDB.sex = usuario.sex;
                userDB.password = usuario.password;
                userDB.cellphone = usuario.cellphone;
                userDB.Id = usuario.Id;
                userDB.country = usuario.country;
                userDB.city = usuario.city;
                userDB.addressStreet = usuario.addressStreet;
                userDB.addressNumber1 = usuario.addressNumber1;
                userDB.addressNumber2 = usuario.addressNumber2;
                userDB.addressNumber3 = usuario.addressNumber3;
                userDB.addressLocation = usuario.addressLocation;
                userDB.address = usuario.addressStreet + " " + usuario.addressNumber1 + " # " + usuario.addressNumber2 + " - " + usuario.addressNumber3 + " " + usuario.addressLocation;
                //TODO: Add insert logic here
                _context.Usuarios.Add(userDB);
                _context.SaveChanges();

                return RedirectToAction("Index", "Convoca");
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        ///
        ///
        ///
        ///


        // GET: User/Edit/5
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
        public ActionResult Edit(int id, UsersModel datosUpdate)
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

                    return RedirectToAction("Index", "Cuenta");
                }
                else
                    return NotFound();
            }
            catch
            {
                return View();
            }
        }

        ///
        ///
        ///
        ///

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