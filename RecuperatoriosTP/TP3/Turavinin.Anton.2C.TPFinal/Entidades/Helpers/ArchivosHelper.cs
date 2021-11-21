using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Helpers
{
    public class ArchivosHelper<T> : IArchivos<T>
    {
        private string rutaArchivo;

        public ArchivosHelper() : this(string.Empty)
        {
        }

        public ArchivosHelper(string nombreArchivo)
        {
            this.rutaArchivo = this.ConstruirRuta(nombreArchivo);
        }

        private string ConstruirRuta(string nombreArchivo)
        {
            //string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(ruta, nombreArchivo);
        }


        public void Exportar(T obj, string ruta = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ruta))
                {
                    ruta = this.rutaArchivo;
                }

                string jsonObj = JsonSerializer.Serialize(obj);
                File.WriteAllText(ruta, jsonObj);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Importar(string ruta = "")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ruta))
                {
                    ruta = this.rutaArchivo;
                }

                return JsonSerializer.Deserialize<T>(File.ReadAllText(ruta));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
