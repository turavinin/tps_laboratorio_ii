using Entidades.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Helpers
{
    public class BasesDatosHelper
    {
        private string connString;

        public BasesDatosHelper(string connString)
        {
            this.connString = connString;
        }

        public BasesDatosHelper() : this(@"Server = DESKTOP-GRO5P3H; Database=TP4;Trusted_Connection=True;")
        {
        }

        /// <summary>
        /// Ejecuta la query con los parametros enviados.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parametros"></param>
        /// <returns>Retorna true si se ejecutó correctamente la query.</returns>
        public bool EjecutarQuery(string query, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConn);

                    if (parametros is not null)
                    {
                        foreach (var item in parametros)
                        {
                            sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }

                    return sqlCommand.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new EncuestaException("Error al ejecutar la query.", ex);
            }
        }

        /// <summary>
        /// Importa la lista de personas de la base. 
        /// </summary>
        /// <returns>Retorna la lista de personas.</returns>
        public List<Persona> ImportarListaPersonas()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(this.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.[Personas]", sqlConn);
                    List<Persona> personas = new List<Persona>();

                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        personas.Add(new Persona()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Nombre = reader["Nombre"].ToString(),
                            Edad = int.Parse(reader["Edad"].ToString()),
                            Sexo = reader["Genero"].ToString(),
                            PuestoId = int.Parse(reader["PuestoId"].ToString()),
                            ExperienciaId = int.Parse(reader["ExperienciaId"].ToString()),
                            Salario = decimal.Parse(reader["Salario"].ToString())
                        });
                    }
                    return personas.OrderBy(x => x.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new EncuestaException("Error al intentar cargar a la persona", ex);
            }
        }

        /// <summary>
        /// Importa la lista de puestos de la base. 
        /// </summary>
        /// <returns>Retorna la lista de puestos.</returns>
        public List<Puesto> ImportarListaPuestos()
        {
            try
            {


                using (SqlConnection sqlConn = new SqlConnection(this.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.[Puestos]", sqlConn);
                    List<Puesto> puestos = new List<Puesto>();

                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        puestos.Add(new Puesto()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Descripcion = reader["Descripcion"].ToString()
                        });
                    }
                    return puestos.OrderBy(x => x.Id).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new EncuestaException("Error al intentar cargar al puesto", ex);
            }
        }

        /// <summary>
        /// Importa la lista de experiencias de la base. 
        /// </summary>
        /// <returns>Retorna la lista de experiencias.</returns>
        public List<Experiencia> ImportarListaExperiencia()
        {
            try
            {


                using (SqlConnection sqlConn = new SqlConnection(this.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.[Experiencias]", sqlConn);
                    List<Experiencia> experiencias = new List<Experiencia>();

                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        experiencias.Add(new Experiencia()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            TipoExperiencia = reader["Descripcion"].ToString()
                        });
                    }
                    return experiencias.OrderBy(x => x.Id).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new EncuestaException("Error al intentar cargar las experiencias", ex);
            }
        }
    }
}
