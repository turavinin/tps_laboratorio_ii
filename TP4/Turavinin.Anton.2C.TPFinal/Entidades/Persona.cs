using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private int edad;
        private string genero;
        private int rolId;
        private string experiencia;
        private decimal salario;

        public int Id { get => this.id; set => this.id = value > 0 ? value : 0; }
        public string Nombre { get => this.nombre; set => this.nombre = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public int Edad { get => this.edad; set => this.edad = value > 0 ? value : 0; }
        public string Genero { get => this.genero; set => this.genero = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public int RolId { get => this.rolId; set => this.rolId = value > 0 ? value : 0; }
        public string Experiencia { get => this.experiencia; set => this.experiencia = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public decimal Salario { get => this.salario; set => this.salario = value > 0 ? value : 0; }


        #region Constructores
        public Persona() : this(0, string.Empty, 0, string.Empty, 0, string.Empty, 0)
        {
        }

        public Persona(int id, string nombre, int edad, string genero, int rolId, string experiencia, decimal salario)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.RolId = rolId;
            this.Experiencia = experiencia;
            this.Salario = salario;
        } 
        #endregion

        #region Querys
        public static string QueryGuardar()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"INSERT INTO dbo.[Personas]");
            sql.AppendLine($"(Nombre, Edad, Genero, RolId, Experiencia, Salario)");
            sql.AppendLine($"VALUES (@Nombre, @Edad, @Genero, @RolId, @Experiencia, @Salario)");
            return sql.ToString();
        }

        public static string QueryActualizar()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"UPDATE dbo.[Personas]");
            sql.AppendLine($"SET Nombre = @Nombre, Edad = @Edad, Genero = @Genero, RolId = @RolId, Experiencia = @Experiencia, Salario = @Salario");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static string QueryEliminar()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"DELETE FROM dbo.[Personas]");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static Dictionary<string, object> Parametros(Persona persona)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object>();
            if (persona.Id > 0)
            {
                diccionario.Add("Id", persona.Id);
            }
            diccionario.Add("Nombre", persona.Nombre);
            diccionario.Add("Edad", persona.Edad);
            diccionario.Add("Genero", persona.Genero);
            diccionario.Add("RolId", persona.RolId);
            diccionario.Add("Experiencia", persona.Experiencia);
            diccionario.Add("Salario", persona.Salario);
            return diccionario;
        } 
        #endregion
    }
}
