using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Final_prog2.Models
{
    [Serializable]
    public class Facultad
    {
        private List<Curso> listaCursos = new List<Curso>();
        public void AgregarCurso(Curso cu)
        {
            listaCursos.Add(cu);
        }
        public void AgregarAlumno(string nom,long dni,int leg,int idx)
        {
            Alumno a = new Alumno(leg,nom,dni);
            listaCursos[idx].AgregarAlumno(a);
        }
        public List<Curso> DevolverLista()
        {
            return listaCursos;
        }
    }
}
