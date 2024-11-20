using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final_prog2.Models
{
    [Serializable]
    public class Alumno:Persona
    {
        public int Legajo {  get; set; }

        public Alumno(int legajo,string nom, long dni):base(nom,dni)
        {
            Legajo = legajo;
        }
    }
}
