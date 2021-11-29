using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Roles
    {
        private int id;
        private string descripcion;

        public int Id { get => this.id; set => this.id = value > 0 ? value : 0; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }


        #region Constructores
        public Roles() : this(0, string.Empty)
        {
        }

        public Roles(int id) : this(id, string.Empty)
        {

        }

        public Roles(string descripcion) : this(0, descripcion)
        {
        }

        public Roles(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        } 
        #endregion

        #region Querys
        public static string QueryGuardar()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"INSERT INTO dbo.[Roles]");
            sql.AppendLine($"(Descripcion)");
            sql.AppendLine($"VALUES (@Descripcion)");
            return sql.ToString();
        }

        public static string QueryActualizar()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"UPDATE dbo.[Roles]");
            sql.AppendLine($"SET Descripcion = @Descripcion");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static string QueryEliminar()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"DELETE FROM dbo.[Roles]");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static Dictionary<string, object> Parametros(Roles rol)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object>();
            if (rol.Id > 0)
            {
                diccionario.Add("Id", rol.Id);
            }
            diccionario.Add("Descripcion", rol.Descripcion);
            return diccionario;
        }
        #endregion
    }
}
