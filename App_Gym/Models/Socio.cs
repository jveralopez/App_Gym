using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App_Gym.Models
{
    public class Socio: Persona
    {
       
       
        public int IdSocio { get; set; }

        List<Turno> Turnos;


    }
}
