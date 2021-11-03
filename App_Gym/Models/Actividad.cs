using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App_Gym.Models
{
    public class Actividad
    {
        [Key]
        public int idActividad { get; set; }
        public int cantTurnos { get; set; }
        public int cantTurnosDisponibles { get; set; }
        public string nombre { get; set; }
        public DateTime horario { get; set; }
        public Profesor profesor { get; set; }
    }
}
