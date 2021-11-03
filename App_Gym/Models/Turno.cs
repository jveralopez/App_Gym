using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App_Gym.Models
{
    public class Turno
    {
        [Key]
        public int IdTurno { get; set; }

        public DateTime Dia { get; set; }

        public string Horario { get; set; }

        public Boolean Activo { get; set; }

        public Socio Socio { get; set; }

        public Actividad Actividad { get; set; }




    }
}
