using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public  class Curso
    {
        public int anio { get; set; }
        public Divisiones Division { get; set; }
        public List<Persona> ListaPersona { get; set; }

        private Curso()
        {
            ListaPersona = new List<Persona>();
        }
        public Curso(int anios,Divisiones divisiones):this()
        {
            anio = anios;
            Division = divisiones;
        }
     


        public override string ToString()
        {
            return "";
        }
        public string AnioDivision()
        {
            return $"{anio = 1}-{Division = Divisiones.A}";
        }
        public static bool operator+(Curso curso,Profesor profesor)
        {
            if (!curso.ListaPersona.Contains(profesor))
            {
                return true;
            }
            return false;
        }
        public static bool operator +(Curso curso,Estudiante estudiante)
        {
            if (!curso.ListaPersona.Contains(estudiante))
            {
                return true;
            }
            return false;
        }
        public static bool operator == (Curso curso,Estudiante estudiante1)
        {
            return (curso.anio==estudiante1.Anio);
        }
        public static bool operator !=(Curso curso, Estudiante estudiante1)
        {
            return !(curso.Division == estudiante1.Division);
        }

        public static explicit operator string(Curso curso)
        {
            return $"{curso.anio}-{curso.Division}-{curso.ListaPersona}";
        }


    }
}
