using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Gym.Models;

namespace App_Gym.Context
{
    public class App_GymDabataseContext : DbContext
    {
        public App_GymDabataseContext(DbContextOptions<App_GymDabataseContext> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Socio> Socios { get; set; }

        public DbSet<Turno> Turnos { get; set; }

        public DbSet<Actividad> Actividades { get; set; }

        public DbSet<Profesor> Profesores { get; set; }


    }
}

    

