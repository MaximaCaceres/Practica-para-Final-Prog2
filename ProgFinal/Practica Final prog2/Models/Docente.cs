using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final_prog2.Models
{
    [Serializable]
    public class Docente:Persona
    {
        public string Especialidad {  get; set; }
        public Docente(string especialidad, string nombre, long dni) : base(nombre, dni)
        {
            Especialidad = especialidad;
        }
    }
}
