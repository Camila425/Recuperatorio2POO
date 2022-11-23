using Recuperatorio2POO.Datos;
using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //JSON

            var estudiante = new Estudiante() { Nombre1 = "camila",Apellido1="rivas" };
            var estudiante2 = new Estudiante() { Nombre1 = "nombre1", Apellido1 = "apellido" };


            var estudiantes = new Estudiante()
            {
                estudiantes = new List<Estudiante>() { estudiante, estudiante2 }
            };


            var listaEstudiantes = new List<Estudiante>() { estudiantes };
            Serializador<List<Estudiante>>.GuardarJson("estudiantes.txt", listaEstudiantes);
            Console.WriteLine("serializacion completa");

            //crear un curso
            Curso curso = new Curso(2022,Divisiones.B);
            Estudiante et1 = new Estudiante(2022, Divisiones.B, "nombre1", "apellido1", 44543321);
            Estudiante et2= new Estudiante(2022, Divisiones.B, "nombre2", "apellido2", 39876543);
            Estudiante et3 = new Estudiante(2022, Divisiones.B, "nombre3", "apellido3", 23456789);
            Estudiante et4 = new Estudiante(2022, Divisiones.B, "nombre4", "apellido4", 12345678);

            Estudiante et5 = new Estudiante(2021, Divisiones.C, "nombre5", "apellido5", 21323232);
            Estudiante et6 = new Estudiante(2020, Divisiones.E, "nombre6", "apellido6", 17876543);

            if (curso+et1)
            {
                Console.WriteLine("estudiante agregado");
            }
            else
            {
                Console.WriteLine("estudiante no agregado");
            }
            Profesor profesor = new Profesor(DateTime.Now,"nombre1","apellido1",66544432);
            Profesor profesor1 = new Profesor(DateTime.Now, "nombre2", "apellido2", 66544432);

            Console.ReadLine();

        }
    }
}
