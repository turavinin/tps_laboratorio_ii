using Entidades.CustomExceptions;
using Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EncuestaManager
    {
        private List<Persona> personas;
        private List<Puesto> puestos;
        private List<Experiencia> experiencias;
        private PerfilPersonas perfilPersonas;
        private EstadisticasPuestos estadisticaPuestos;

        public List<Persona> Personas { get => this.personas; set => this.personas = value.Count > 0 ? value : null; }
        public List<Puesto> Puestos { get => this.puestos; set => this.puestos = value.Count > 0 ? value : null; }
        public List<Experiencia> Experiencias { get => this.experiencias; set => this.experiencias = value.Count > 0 ? value : null; }
        public PerfilPersonas PerfilPersonas { get => this.perfilPersonas; set => this.perfilPersonas = value is not null ? value : null; }
        public EstadisticasPuestos EstadisticaPuestos { get => this.estadisticaPuestos; set => this.estadisticaPuestos = value is not null ? value : null; }

        public EncuestaManager()
        {
            personas = new List<Persona>();
            puestos = new List<Puesto>();
            experiencias = new List<Experiencia>();
            perfilPersonas = new PerfilPersonas();
            estadisticaPuestos = new EstadisticasPuestos();
        }

        /// <summary>
        /// Carga la lista con los datos de la base.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public void CargarListaEntidad<T>() where T : class
        {
            BasesDatosHelper bdPersonaHelper = new BasesDatosHelper();
            if (typeof(T) == typeof(Persona))
            {
                this.personas = bdPersonaHelper.ImportarListaPersonas();
            }
            else if (typeof(T) == typeof(Puesto))
            {
                this.puestos = bdPersonaHelper.ImportarListaPuestos();
            }
            else if (typeof(T) == typeof(Experiencia))
            {
               this.experiencias = bdPersonaHelper.ImportarListaExperiencia();
            }
        }

        /// <summary>
        /// Guarda entidad en la base.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns>Retorna true si se eliminó la entidad.</returns>
        public bool GuardarEntidad<T>(T obj) where T : class
        {
            BasesDatosHelper basesDatosHelper = new BasesDatosHelper();

            if (obj.GetType() == typeof(Persona))
            {
                return basesDatosHelper.EjecutarQuery(Persona.QueryGuardarParametrizado(), Persona.Parametros(obj as Persona));
            }
            else if (obj.GetType() == typeof(Puesto))
            {
                return basesDatosHelper.EjecutarQuery(Puesto.QueryGuardarParametrizado(), Puesto.Parametros(obj as Puesto));
            }

            return false;
        }

        /// <summary>
        /// Actualiza entidad en la base.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns>Retorna true si se eliminó la entidad.</returns>
        public bool ActualizarEntidad<T>(T obj) where T : class
        {
            BasesDatosHelper basesDatosHelper = new BasesDatosHelper();

            if (obj.GetType() == typeof(Persona))
            {
                return basesDatosHelper.EjecutarQuery(Persona.QueryActualizarParametrizado(), Persona.Parametros(obj as Persona));
            }
            else if (obj.GetType() == typeof(Puesto))
            {
                return basesDatosHelper.EjecutarQuery(Puesto.QueryActualizarParametrizado(), Puesto.Parametros(obj as Puesto));
            }

            return false;
        }

        /// <summary>
        /// Elimina entidad de la base.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        public void EliminarEntidad<T>(int id) where T : class
        {
            BasesDatosHelper basesDatosHelper = new BasesDatosHelper();

            if (typeof(T) == typeof(Persona))
            {
                basesDatosHelper.EjecutarQuery(Persona.QueryEliminarParametrizado(), Persona.Parametros(new Persona() { Id = id }));
            }
            else if (typeof(T) == typeof(Puesto))
            {
                basesDatosHelper.EjecutarQuery(Puesto.QueryEliminarParametrizado(), Puesto.Parametros(new Puesto() { Id = id }));
            }
        }

        /// <summary>
        /// Elimina registro de la lista.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns>Retorna true si se eliminó la entidad.</returns>
        public bool EliminarRegistroLista<T>(T obj) where T : class
        {
            if (obj.GetType() == typeof(Persona))
            {
                return this.personas.Remove(obj as Persona);
            }
            else if (obj.GetType() == typeof(Puesto))
            {
                return this.puestos.Remove(obj as Puesto);
            }
            else if (obj.GetType() == typeof(Experiencia))
            {
                return this.experiencias.Remove(obj as Experiencia);
            }
            return false;
        }

        /// <summary>
        /// Busca entidad en la lista por su id.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns>Retorna la entidad</returns>
        public T EncontrarRegistroLista<T>(string id) where T : class
        {
            if (typeof(T) == typeof(Persona))
            {
                return this.personas.Where(x => x.Id.ToString() == id).FirstOrDefault() as T;
            }
            else if (typeof(T) == typeof(Puesto))
            {
                return this.puestos.Where(x => x.Id.ToString() == id).FirstOrDefault() as T;
            }
            else if (typeof(T) == typeof(Experiencia))
            {
                return this.experiencias.Where(x => x.Id.ToString() == id).FirstOrDefault() as T;
            }
            return null;
        }

        /// <summary>
        /// Busca entidad en la lista por su id.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns>Retorna la entidad</returns>
        public T EncontrarRegistroLista<T>(int id) where T : class
        {
            return this.EncontrarRegistroLista<T>(id.ToString());
        }

        /// <summary>
        /// Obtiene el siguiente Id de entidades. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Retorna el Id</returns>
        public int ObtenerSiguienteId<T>() where T : class
        {
            if (typeof(T) == typeof(Persona))
            {
                return this.personas.Max(x => x.Id) + 1;
            }
            else if (typeof(T) == typeof(Puesto))
            {
                return this.puestos.Max(x => x.Id) + 1;
            }
            else if (typeof(T) == typeof(Experiencia))
            {
                return this.experiencias.Max(x => x.Id) + 1;
            }
            return 0;
        }

        /// <summary>
        /// Obtiene el Id por nombre / descripcion.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="nombre"></param>
        /// <returns>Retorna el id/returns>
        public int GetIdByNombreLista<T>(string nombre) where T : class
        {
            if (typeof(T) == typeof(Persona))
            {
                return this.personas.Where(x => x.Nombre == nombre).FirstOrDefault().Id;
            }
            else if (typeof(T) == typeof(Puesto))
            {
                return this.puestos.Where(x => x.Descripcion == nombre).FirstOrDefault().Id;
            }
            else if (typeof(T) == typeof(Experiencia))
            {
                return this.experiencias.Where(x => x.TipoExperiencia == nombre).FirstOrDefault().Id;
            }
            return 0;
        }

        /// <summary>
        /// Método encargado de calcular la información del perfil de personas. 
        /// </summary>
        public void CalcularPerfilPersonas()
        {
            this.perfilPersonas.TotalPersonas = personas.Count;
            this.perfilPersonas.TotalHombresCis = personas.Count(x => x.Sexo == "Hombre Cis");
            this.perfilPersonas.TotalMujeresCis = personas.Count(x => x.Sexo == "Mujer Cis");
            this.perfilPersonas.TotalNoBinarie = personas.Count(x => x.Sexo == "No Binarie");
            this.perfilPersonas.TotalHombresTrans = personas.Count(x => x.Sexo == "Hombre Trans");
            this.perfilPersonas.TotalMujeresTrans = personas.Count(x => x.Sexo == "Mujer Trans");
            this.perfilPersonas.TotalAgenero = personas.Count(x => x.Sexo == "Agenero");

            this.perfilPersonas.TotalEntre20y30 = personas.Count(x => x.Edad >= 20 && x.Edad <= 30);
            this.perfilPersonas.TotalEntre30y40 = personas.Count(x => x.Edad >= 30 && x.Edad <= 40);
            this.perfilPersonas.TotalEntre40y50 = personas.Count(x => x.Edad >= 40 && x.Edad <= 50);
            this.perfilPersonas.TotalMasDe50 = personas.Count(x => x.Edad > 50);

            this.PerfilPersonas.CalcularPorcentajes();
        }

        /// <summary>
        /// Método encargado de calcular la estadística de puestos.
        /// </summary>
        public void EstablecerEstadisticasPuestos()
        {
            this.estadisticaPuestos.TotalPuestos = puestos.Count;

            var listaOrdenadaPuestos = personas.GroupBy(x => x.PuestoId).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).ToList();
            int idPuestoMejorPagado = personas.Where(x => x.Salario == personas.Max(x => x.Salario)).FirstOrDefault().PuestoId;
            int idPuestoPeorPagado = personas.Where(x => x.Salario == personas.Min(x => x.Salario)).FirstOrDefault().PuestoId;

            this.estadisticaPuestos.PuestoMasNumeroso = puestos.Where(x => x.Id == listaOrdenadaPuestos.First()).FirstOrDefault().Descripcion;
            this.estadisticaPuestos.PuestoMenosNumeroso = puestos.Where(x => x.Id == listaOrdenadaPuestos.Last()).FirstOrDefault().Descripcion;
            this.estadisticaPuestos.PuestoMejorPagado = puestos.Where(x => x.Id == idPuestoMejorPagado).FirstOrDefault().Descripcion;
            this.estadisticaPuestos.PuestoPeorPagado = puestos.Where(x => x.Id == idPuestoPeorPagado).FirstOrDefault().Descripcion;
        }
    }
}
