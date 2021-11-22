using Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private string sexo;
        private int puestoId;
        private int experienciaId;
        private decimal salario;


        public int Id { get => this.id; set => this.id = value > 0 ? value : 0; }
        public string Nombre { get => this.nombre; set => this.nombre = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public int Edad { get => this.edad; set => this.edad = value > 0 ? value : 0; }
        public string Sexo { get => this.sexo; set => this.sexo = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }
        public int PuestoId { get => this.puestoId; set => this.puestoId = value > 0 ? value : 0; }
        public int ExperienciaId { get => this.experienciaId; set => this.experienciaId = value > 0 ? value : 0; }
        public decimal Salario { get => this.salario; set => this.salario = value > 0 ? value : 0; }



        public Persona() : this(0, string.Empty, 0, string.Empty, 0, 0, 0)
        {
        }

        public Persona(int id, string nombre, int edad, string sexo, int puestoId, int experienciaId, decimal salario)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
            this.PuestoId = puestoId;
            this.ExperienciaId = experienciaId;
            this.Salario = salario;
        }

        public static string QueryGuardarParametrizado()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"INSERT INTO dbo.[Personas]");
            sql.AppendLine($"(Nombre, Edad, Genero, PuestoId, ExperienciaId, Salario)");
            sql.AppendLine($"VALUES (@Nombre, @Edad, @Genero, @PuestoId, @ExperienciaId, @Salario)");
            return sql.ToString();
        }

        public static string QueryActualizarParametrizado()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"UPDATE dbo.[Personas]");
            sql.AppendLine($"SET Nombre = @Nombre, Edad = @Edad, Genero = @Genero, PuestoId = @PuestoId, ExperienciaId = @ExperienciaId, Salario = @Salario");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static string QueryEliminarParametrizado()
        {
            StringBuilder sql = new StringBuilder();
            sql.AppendLine($"DELETE FROM dbo.[Personas]");
            sql.AppendLine($"WHERE Id = @Id");
            return sql.ToString();
        }

        public static Dictionary<string, object> Parametros(Persona persona)
        {
            Dictionary<string, object> diccionario = new Dictionary<string, object>();
            if(persona.Id > 0)
            {
                diccionario.Add("Id", persona.Id);
            }
            diccionario.Add("Nombre", persona.Nombre);
            diccionario.Add("Edad", persona.Edad);
            diccionario.Add("Genero", persona.Sexo);
            diccionario.Add("PuestoId", persona.PuestoId);
            diccionario.Add("ExperienciaId", persona.ExperienciaId);
            diccionario.Add("Salario", persona.Salario);
            return diccionario;
        }
    }
}
