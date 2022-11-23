using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }

        public Profesor(DateTime fecha,string nom,string apellido,double dni):base(nom,apellido,dni)
        {
           
        }
        public Profesor(string nom, string apellido, double dni) : base(nom, apellido, dni)
        {
            FechaIngreso =DateTime.Now;
        }

        public  DateTime Antiguedad()
        {
            return FechaIngreso;
        }
        public override string ExponerDatos()
        {
            return $"{FechaIngreso}-{Nombre1}-{Apellido1}-{Documento1}";
        }

        public override double ValidarDocumentacion()
        {
            throw new NotImplementedException();
        }
    }
}
