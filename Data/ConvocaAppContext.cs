using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConvocaApp.Models;

namespace ConvocaApp.Data
{
    public class ConvocaAppContext : DbContext
    {
        public ConvocaAppContext (DbContextOptions<ConvocaAppContext> options)
            : base(options)
        {
        }

        //Todas las clases del Moedlo que se requiere se incluyan como tablas
        //de la DB
        public DbSet<ConvocaApp.Models.UsersModel> Usuarios { get; set; }
        public DbSet<ConvocaApp.Models.SportsModel> Deportes { get; set; }
        public DbSet<ConvocaApp.Models.EventsModel> Eventos { get; set; }
        public DbSet<ConvocaApp.Models.PlacesModel> Lugares { get; set; }
        public DbSet<ConvocaApp.Models.ConvocadosModel> Convocados { get; set; }
        public DbSet<ConvocaApp.Models.CitiesModel> Ciudades { get; set; }
        public DbSet<ConvocaApp.Models.ActivitiesModel> ActividadesFisicas { get; set; }
        public DbSet<ConvocaApp.Models.AccesoriesModel> Accesorios { get; set; }       


    }
}
