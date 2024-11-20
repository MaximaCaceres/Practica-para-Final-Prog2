using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final_prog2.Models
{
    [Serializable]
    public class Curso
    {
        private string nombreCurso = "";
        private Docente docEnCargo;
        private List<Alumno> alumnosEnCurso = new List<Alumno>();
        public Curso(string nom,long dni, string esp, string nombC)
        {
            docEnCargo = new Docente(esp,nom,dni);

            nombreCurso = nombC;
        }
        public List<Alumno> VerAlumnos()
        {
            return alumnosEnCurso;
        }
        public override string ToString()
        {
            return nombreCurso;
        }
        public void AgregarAlumno(Alumno alum)
        {
            alumnosEnCurso.Add(alum);
        }
    }
}
