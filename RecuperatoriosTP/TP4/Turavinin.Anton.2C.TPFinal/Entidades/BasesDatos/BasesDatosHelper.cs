using Entidades.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.BasesDatos
{
    public delegate void DelegadoBase(bool conexionActiva);

    public class BasesDatosHelper : IBasesDatosHelper
    {
        private static string connString;
        public static bool conexionLograda;
        private SqlConnection conexion;
        public event DelegadoBase EventoConexion;

        public static string ConnectionString
        {
            get
            {
                return BasesDatosHelper.connString;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    BasesDatosHelper.connString = value;
                }
            }
        }

        static BasesDatosHelper()
        {
            BasesDatosHelper.conexionLograda = false;
            BasesDatosHelper.connString = string.Empty;
        }

        public BasesDatosHelper() : this(string.Empty)
        {
        }

        public BasesDatosHelper(string connString)
        {
            if (!string.IsNullOrEmpty(connString))
            {
                BasesDatosHelper.connString = connString;
            }
        }

        /// <summary>
        /// Prueba la conexión a la base
        /// </summary>
        /// <returns>Retorna true si la conexión fue lograda.</returns>
        public bool ConexionLograda()
        {
            var output = true;

            try
            {
                conexion = new SqlConnection(BasesDatosHelper.connString);
                conexion.Open();
            }
            catch (Exception ex)
            {
                output = false;
                BasesDatosHelper.conexionLograda = false;
            }
            finally
            {
                if (conexion is not null && conexion.State == ConnectionState.Open)
                {
                    BasesDatosHelper.conexionLograda = true;
                    conexion.Close();
                }

                if (this.EventoConexion is not null)
                {
                    this.EventoConexion.Invoke(BasesDatosHelper.conexionLograda);
                }
            }

            return output;
        }

        /// <summary>
        /// Ejecuta una query con los parametros opcionales.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parametros"></param>
        /// <returns>Retorna true si la query fue ejecutada correctamente.</returns>
        public static bool EjecutarQuery(string query, Dictionary<string, object> parametros = null)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(BasesDatosHelper.connString))
                {
                    conexion.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, conexion);

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
                throw new ExceptionsInternas("Error al realizar la operación.", ex);
            }
        }

        /// <summary>
        /// Importa las personas de la base.
        /// </summary>
        /// <returns>Retorna una lista de personas</returns>
        public static List<Persona> ImportarPersonas()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(BasesDatosHelper.connString))
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
                            Genero = reader["Genero"].ToString(),
                            RolId = int.Parse(reader["RolId"].ToString()),
                            Experiencia = reader["Experiencia"].ToString(),
                            Salario = decimal.Parse(reader["Salario"].ToString())
                        });
                    }
                    return personas.OrderBy(x => x.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionsInternas("Error al intentar cargar a la persona", ex);
            }
        }

        /// <summary>
        /// Importa los roles de la base.
        /// </summary>
        /// <returns>Retorna una lista de roles</returns>
        public static List<Roles> ImportarRoles()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(BasesDatosHelper.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.[Roles]", sqlConn);
                    List<Roles> roles = new List<Roles>();

                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        roles.Add(new Roles()
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Descripcion = reader["Descripcion"].ToString()
                        });
                    }
                    return roles.OrderBy(x => x.Id).ToList();
                }

            }
            catch (Exception ex)
            {
                throw new ExceptionsInternas("Error al intentar cargar los roles", ex);
            }
        }

        /// <summary>
        /// Importa una persona de la base por Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna a la persona</returns>
        public static Persona ImportarPersonaPorId(int id)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(BasesDatosHelper.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.[Personas] WHERE [Personas].Id = @Id", sqlConn);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    Persona persona = new Persona();

                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        persona.Id = int.Parse(reader["Id"].ToString());
                        persona.Nombre = reader["Nombre"].ToString();
                        persona.Edad = int.Parse(reader["Edad"].ToString());
                        persona.Genero = reader["Genero"].ToString();
                        persona.RolId = int.Parse(reader["RolId"].ToString());
                        persona.Experiencia = reader["Experiencia"].ToString();
                        persona.Salario = decimal.Parse(reader["Salario"].ToString());
                    }
                    return persona;
                }
            }
            catch (Exception ex)
            {
                throw new ExceptionsInternas("Error al intentar cargar a la persona", ex);
            }
        }

        /// <summary>
        /// Importa un rol de la base por Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna al rol</returns>
        public static Roles ImportarRolPorId(int id)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(BasesDatosHelper.connString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM dbo.[Roles] WHERE [Roles].Id = @Id", sqlConn);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    Roles rol = new Roles();

                    var reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        rol.Id = int.Parse(reader["Id"].ToString());
                        rol.Descripcion = reader["Descripcion"].ToString();
                    }
                    return rol;
                }

            }
            catch (Exception ex)
            {
                throw new ExceptionsInternas("Error al intentar cargar el rol", ex);
            }
        }
    }
}
