using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Puesto
    {
        private int id;
        private string descripcion;


        public int Id { get => this.id; set => this.id = value > 0 ? value : 0; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }

        public Puesto() : this(0, string.Empty)
        {

        }

        public Puesto(string descripcion) : this(0, descripcion)
        {

        }

        public Puesto(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public static string QueryGuardarParametrizado()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"INSERT INTO dbo.[Puestos]");
            sql.AppendLine($"(Descripcion)");
            sql.AppendLine($"VALUES (@Descripcion)");
            return sql.ToString();
        }

        public static string QueryActualizarParametrizado()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"UPDATE dbo.[Puestos]");
            sql.AppendLine($"SET Descripcion = @Descripcion");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static string QueryEliminarParametrizado()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"DELETE FROM dbo.[Puestos]");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static Dictionary<string, object> Parametros(Puesto puesto)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object>();
            if(puesto.Id > 0)
            {
                diccionario.Add("Id", puesto.Id);
            }
            diccionario.Add("Descripcion", puesto.Descripcion);
            return diccionario;
        }
    }
}
