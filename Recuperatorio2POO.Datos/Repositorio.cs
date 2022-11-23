using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Datos
{
    public class Repositorio
    {
        private List<Estudiante> listaestudiantes;
        private List<Profesor>listaprofesores;
        public void Agregar(Estudiante estudiante)
        {
            listaestudiantes.Add(estudiante);
        }

        public void AgregarProfesor(Profesor profesor)
        {
            listaprofesores.Add(profesor);
        }
    }
}
