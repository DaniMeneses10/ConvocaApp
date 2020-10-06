using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ConvocaApp.Data;
using ConvocaApp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;

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

        public IActionResult Index(string id)
        {

            var eventos = _context.Eventos.ToList<EventsModel>();

            var eventosVMlist = new List<EventsViewModel>();
            foreach (var evento in eventos)

            {
                var eventoVM = new EventsViewModel();
                eventoVM.category = evento.category;
                eventoVM.sex = evento.sex;
                eventoVM.date = evento.date;
                eventoVM.hour = evento.hour;
                eventoVM.minute = evento.minute;
                eventoVM.meridian = evento.meridian;
                eventoVM.Id = evento.Id;

                eventoVM.time = evento.hour + " : " + evento.minute + " - " + evento.meridian;
                eventoVM.time = evento.time;

                eventoVM.reserve = evento.reserve;
                eventoVM.cost = evento.cost;
                eventoVM.paymment = evento.paymment;

                eventoVM.place_id = evento.place_id;
                var lugarEvento = _context.Lugares.Find(evento.place_id);
                eventoVM.place_name = lugarEvento.name;

                eventoVM.sport_id = evento.sport_id;
                var deporteEvento = _context.Deportes.Find(evento.sport_id);
                eventoVM.sport_name = deporteEvento.name;

                string picture_url;

                switch (eventoVM.sport_name)
                {
                    case "Baloncesto":
                        picture_url = "~/asset/images/baloncesto.jpg";
                        break;
                    case "Futbol":
                        picture_url = "~/asset/images/futbol.jpg";
                        break;
                    case "Tenis":
                        picture_url = "~/asset/images/tenis.jpg";
                        break;
                    case "Atletismo":
                        picture_url = "~/asset/images/atletismo.jpg";
                        break;
                    case "Ciclismo":
                        picture_url = "~/asset/images/ciclismo.jpg";
                        break;
                    default:
                        picture_url = "Sin Imagenes para mostrar";
                        break;
                }

                eventoVM.picture_url = picture_url;


                if (id == eventoVM.sport_name)
                {
                    eventosVMlist.Add(eventoVM);
                }
                else if (id == "AllEvents")
                {
                    eventosVMlist.Add(eventoVM);
                }
                else if (id == null)
                {
                    //return RedirectToAction("Events", "Index");
                    return RedirectToAction("Convoca", "Convoca");

                }

            }

            //if (eventosVMlist.Count != 0)
            //    return View(eventosVMlist);
            //else
            //    return NotFound("No hay eventos");

            return View(eventosVMlist);

            //return View(eventos);           
        }


        // GET: Events/Details/5
        public IActionResult Details(int id)
        {

            var evento = _context.Eventos.Find(id);

            var eventoVM = new EventsViewModel();
            eventoVM.category = evento.category;
            eventoVM.sex = evento.sex;
            eventoVM.date = evento.date;
            eventoVM.hour = evento.hour;
            eventoVM.minute = evento.minute;
            eventoVM.meridian = evento.meridian;
            eventoVM.Id = evento.Id;

            eventoVM.time = evento.hour + " : " + evento.minute + " - " + evento.meridian;
            eventoVM.time = evento.time;

            eventoVM.reserve = evento.reserve;
            eventoVM.cost = evento.cost;
            eventoVM.paymment = evento.paymment;

            eventoVM.place_id = evento.place_id;
            var lugarEvento = _context.Lugares.Find(evento.place_id);
            eventoVM.place_name = lugarEvento.name;

            eventoVM.sport_id = evento.sport_id;
            var deporteEvento = _context.Deportes.Find(evento.sport_id);
            eventoVM.sport_name = deporteEvento.name;

            string picture_url;

            switch (eventoVM.sport_name)
            {
                case "Baloncesto":
                    picture_url = "~/asset/images/baloncesto.jpg";
                    break;
                case "Futbol":
                    picture_url = "~/asset/images/futbol.jpg";
                    break;
                case "Tenis":
                    picture_url = "~/asset/images/tenis.jpg";
                    break;
                case "Atletismo":
                    picture_url = "~/asset/images/atletismo.jpg";
                    break;
                case "Ciclismo":
                    picture_url = "~/asset/images/ciclismo.jpg";
                    break;
                default:
                    picture_url = "Sin Imagenes para mostrar";
                    break;
            }

            eventoVM.picture_url = picture_url;


            if (evento != null)
                return View(eventoVM);
            else
                return NotFound();
        }



        // GET: Events/Create
        public IActionResult Create()
        {
            ViewBag.Lugares = _context.Lugares.ToList();//DB
            ViewBag.Deportes = _context.Deportes.ToList();//DB

            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EventsModel evento)
        {
            try
            {
                var eventoVM = new EventsModel();

                eventoVM.category = evento.category;
                eventoVM.sex = evento.sex;
                eventoVM.reserve = evento.reserve;
                eventoVM.date = evento.date;
                eventoVM.cost = evento.cost;
                eventoVM.paymment = evento.paymment;
                eventoVM.hour = evento.hour;
                eventoVM.minute = evento.minute;
                eventoVM.meridian = evento.meridian;
                eventoVM.Id = evento.Id;

                eventoVM.place_id = evento.place_id;
                eventoVM.sport_id = evento.sport_id;

                eventoVM.time = evento.hour + " : " + evento.minute + " - " + evento.meridian;


                // TODO: Add insert logic here
                _context.Eventos.Add(eventoVM);
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
            ViewBag.Lugares = _context.Lugares.ToList();//DB
            ViewBag.Deportes = _context.Deportes.ToList();//DB
            var evento = _context.Eventos.Find(id);
            if (evento != null)
                return View(evento);
            else
                return NotFound();

        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, EventsModel datosUpdate)
        {
            try
            {
                var eventoVM = _context.Eventos.Find(id);

                if (eventoVM != null)
                {
                    eventoVM.category = datosUpdate.category;
                    eventoVM.sex = datosUpdate.sex;
                    eventoVM.reserve = datosUpdate.reserve;
                    eventoVM.date = datosUpdate.date;
                    eventoVM.cost = datosUpdate.cost;
                    eventoVM.paymment = datosUpdate.paymment;
                    eventoVM.hour = datosUpdate.hour;
                    eventoVM.minute = datosUpdate.minute;
                    eventoVM.meridian = datosUpdate.meridian;
                    eventoVM.Id = datosUpdate.Id;

                    eventoVM.place_id = datosUpdate.place_id;
                    eventoVM.sport_id = datosUpdate.sport_id;

                    eventoVM.time = datosUpdate.hour + " : " + datosUpdate.minute + " - " + datosUpdate.meridian;

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
            var evento = _context.Eventos.Find(id);
            if (evento != null)
                return View(evento);
            else
                return NotFound();
        }

        // POST: Events/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                var evento = _context.Eventos.Find(id);
                if (evento != null)
                {
                    _context.Eventos.Remove(evento);
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

        [Authorize]
        public IActionResult MyEvents(string id)
        {

            var UserIdLogueado = User.Claims.FirstOrDefault(c => c.Type == "UserId");
            var UserIdLogueado1 = Convert.ToInt32(UserIdLogueado.Value);

            //var user = new SqlParameter("user", UserIdLogueado1);

            var EventosList = _context.Eventos.ToArray();
                
            //var ConvocadosList = _context.Convocados.ToList();
            var ConvocadosList = _context.Convocados.FromSqlRaw($"SELECT * FROM Convocados WHERE Convocados.user_id = {UserIdLogueado1}" ).ToArray();

            var query =
                from convocado in ConvocadosList
                join evento in EventosList
                on convocado.event_id equals evento.Id
                //where convocado.user_id == 1107
                where convocado.user_id == UserIdLogueado1
                select new { Convocado = convocado, Evento = evento };



            Console.WriteLine(query);
            Console.WriteLine("Hola");





            //SELECT * FROM Convocados INNER JOIN Eventos ON Convocados.event_id = Eventos.Id WHERE Convocados.user_id=1107






            return View();
            
        }
    }
}


//var eventos = _context.Eventos.ToList<EventsModel>();

//var eventosVMlist = new List<EventsViewModel>();
//foreach (var evento in eventos)

//{
//    var eventoVM = new EventsViewModel();
//    eventoVM.category = evento.category;
//    eventoVM.sex = evento.sex;
//    eventoVM.date = evento.date;
//    eventoVM.hour = evento.hour;
//    eventoVM.minute = evento.minute;
//    eventoVM.meridian = evento.meridian;
//    eventoVM.Id = evento.Id;

//    eventoVM.time = evento.hour + " : " + evento.minute + " - " + evento.meridian;
//    eventoVM.time = evento.time;

//    eventoVM.reserve = evento.reserve;
//    eventoVM.cost = evento.cost;
//    eventoVM.paymment = evento.paymment;

//    eventoVM.place_id = evento.place_id;
//    var lugarEvento = _context.Lugares.Find(evento.place_id);
//    eventoVM.place_name = lugarEvento.name;

//    eventoVM.sport_id = evento.sport_id;
//    var deporteEvento = _context.Deportes.Find(evento.sport_id);
//    eventoVM.sport_name = deporteEvento.name;

//    string picture_url;

//    switch (eventoVM.sport_name)
//    {
//        case "Baloncesto":
//            picture_url = "~/asset/images/baloncesto.jpg";
//            break;
//        case "Futbol":
//            picture_url = "~/asset/images/futbol.jpg";
//            break;
//        case "Tenis":
//            picture_url = "~/asset/images/tenis.jpg";
//            break;
//        case "Atletismo":
//            picture_url = "~/asset/images/atletismo.jpg";
//            break;
//        case "Ciclismo":
//            picture_url = "~/asset/images/ciclismo.jpg";
//            break;
//        default:
//            picture_url = "Sin Imagenes para mostrar";
//            break;
//    }

//    eventoVM.picture_url = picture_url;


//    if (id == eventoVM.sport_name)
//    {
//        eventosVMlist.Add(eventoVM);
//    }
//    else if (id == "AllEvents")
//    {
//        eventosVMlist.Add(eventoVM);
//    }
//    else if (id == null)
//    {
//        //return RedirectToAction("Events", "Index");
//        return RedirectToAction("Convoca", "Convoca");

//    }

//}
//return View(eventosVMlist);            