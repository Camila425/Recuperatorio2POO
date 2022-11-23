using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Entidades
{
    public abstract class Persona
    {
        private string Apellido;
        private double Documento;
        private string Nombre;


        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public double Documento1 { get => Documento; set => Documento = value; }

        public Persona()
        {

        }
        public Persona(string nom,string apellido,double dni)
        {
            this.Nombre = nom;
            this.Apellido1 = apellido;
            this.Documento1 = dni;
        }
  

        public override bool Equals(object obj)
        {
            if (obj==null  || !(obj is Persona))
            {
                return false;
            }
            return this.Documento1 == ((Persona)obj).Documento1;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();  
        }


        public static bool operator==(Persona p1,Persona p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        public abstract string ExponerDatos();//ver si es valido
        public abstract double ValidarDocumentacion();

    }
}
