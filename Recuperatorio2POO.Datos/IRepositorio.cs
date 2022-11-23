using Recuperatorio2POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Datos
{
    public interface IRepositorio
    {
         Persona personas { get; set; }

         void Agregar();
         bool Existe();
        int GetCantidad();
        List<Persona> GetLista();



    }
}
