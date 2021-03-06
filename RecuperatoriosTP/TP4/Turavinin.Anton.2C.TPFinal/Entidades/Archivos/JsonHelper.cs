using Entidades.CustomExceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class JsonHelper<T>
    {
        private static string ConstruirRutaDesktop(string archivo)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            return Path.Combine(rutaEscritorio, archivo);
        }


        public static void Exportar(T obj, string archivo)
        {
            try
            {
                string ruta = ConstruirRutaDesktop(archivo);
                string jsonObj = JsonSerializer.Serialize(obj);
                File.WriteAllText(ruta, jsonObj);
            }
            catch (Exception ex)
            {
                throw new ExceptionsInternas("Error al intentar cargar el archivo", ex);
            }
        }

        public static T Importar(string archivo)
        {
            try
            {
                string ruta = ConstruirRutaDesktop(archivo);
                return JsonSerializer.Deserialize<T>(File.ReadAllText(ruta));
            }
            catch (Exception ex)
            {
                throw new ExceptionsInternas("Error al intentar exportar el archivo", ex);
            }
        }
    }
}
