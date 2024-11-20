using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final_prog2.Models
{
    [Serializable]
    public class Persona
    {
        public string Nombre { get; set; }
        public long Dni {  get; set; }

        public Persona(string nom, long dni)
        {
            Nombre = nom;
            Dni = dni;
        }
    }
}
