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
            var avion = usuario;

            var userdetails = new CuentaModel(avion);
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
    }
}

    //public class CuentaController : Controller
    //{
    //    public IActionResult Index()
    //    {
    //        var a = User;
    //        ViewBag.UserId = User.Claims.FirstOrDefault(c => c.Type == "UserId");
    //        ViewBag.UserEmail = User.Claims.FirstOrDefault(c => c.Type == "UserEmail");
    //        return View();
    //    }
    //}

