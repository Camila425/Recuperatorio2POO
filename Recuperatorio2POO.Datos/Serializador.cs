using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Recuperatorio2POO.Datos
{
    public class Serializador<T>
    {
        public static void GuardarJson(string Archivo,T Objeto)
        {
            using (var Escritor=new StreamWriter(Archivo))
            {
                JsonSerializerOptions Opciones = new JsonSerializerOptions();
                Opciones.WriteIndented = true;
                var stringJson = JsonSerializer.Serialize(Objeto, Opciones);
                Escritor.WriteLine(stringJson);
            }
        }
    }
}
