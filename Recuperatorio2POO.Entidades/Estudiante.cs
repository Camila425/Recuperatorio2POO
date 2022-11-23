using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public class Estudiante : Persona
    {
        private short anio;
        private Divisiones division;

        public short Anio { get => anio; }
        public Divisiones Division { get => division;}
        public List<Estudiante> estudiantes { get; set; }
        public Estudiante(short anios, Divisiones divisiones, string nom, string apellido, double dni) : base(nom, apellido, dni)
        {
            anio = anios;
            division = divisiones;

        }
        public Estudiante()
        {

        }
        public string aniodivision()
        {
            return $"{anio = 1}-{division = Divisiones.A}";
        }

        public override string ExponerDatos()
        {
            return $"{anio}-{division}-{Nombre1}-{Apellido1}";
        }

        public override double ValidarDocumentacion()
        {
            if (Documento1==8)
            {
                
            }
            return Documento1;
        }
    }
}
