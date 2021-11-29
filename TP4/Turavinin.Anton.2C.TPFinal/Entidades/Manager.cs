﻿using Entidades.BasesDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    enum TipoEntidad
    {
        Persona,
        Roles
    }
    public enum Experiencia
    {
        Junior,
        SemiSenior,
        Senior
    }
    public enum Genero
    {
        HombreCis,
        MujerCis,
        NoBinarie,
        HombreTrans,
        MujerTrans,
        Agenero
    }

    public class Manager
    {
        private List<Roles> listaRoles;
        private List<Persona> listaPersonas;
        private Estadisticas estadisticas;

        public List<Roles> ListaRoles { get => this.listaRoles; set => this.listaRoles = value.Count > 0 ? value : null; }
        public List<Persona> ListaPersonas { get => this.listaPersonas; set => this.listaPersonas = value.Count > 0 ? value : null; }
        public Estadisticas Estadisticas
        {
            get => this.estadisticas;
        }

        public int TotalPersonas
        {
            get
            {
                if(this.ListaPersonas.Count > 0)
                {
                    return this.ListaPersonas.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public Manager()
        {
            this.listaRoles = new List<Roles>();
            this.listaPersonas = new List<Persona>();
            this.estadisticas = new Estadisticas();
        }


        public void CargarListaEntidad<T>() where T : class
        {
            switch (this.ObtenerTipo(typeof(T)))
            {
                case TipoEntidad.Persona:
                    this.listaPersonas = BasesDatosHelper.ImportarPersonas();
                    break;
                case TipoEntidad.Roles:
                    this.listaRoles = BasesDatosHelper.ImportarRoles();
                    break;
            }
        }

        public T ObtenerEntidadPorId<T>(int id) where T : class
        {
            switch (this.ObtenerTipo(typeof(T)))
            {
                case TipoEntidad.Persona:
                    return BasesDatosHelper.ImportarPersonaPorId(id) as T;
                case TipoEntidad.Roles:
                    return BasesDatosHelper.ImportarRolPorId(id) as T;
            }

            return new Persona() as T;
        }

        public bool GuardarEntidad<T>(T obj)
        {
            bool entidadGuardada = false;
            switch (this.ObtenerTipo(typeof(T)))
            {
                case TipoEntidad.Persona:
                    entidadGuardada = BasesDatosHelper.EjecutarQuery(Persona.QueryGuardar(), Persona.Parametros(obj as Persona));
                    break;
                case TipoEntidad.Roles:
                    entidadGuardada = BasesDatosHelper.EjecutarQuery(Roles.QueryGuardar(), Roles.Parametros(obj as Roles));
                    break;
            }

            return entidadGuardada;
        }

        public bool ActualizarEntidad<T>(T obj)
        {
            bool entidadActualizada = false;
            switch (this.ObtenerTipo(typeof(T)))
            {
                case TipoEntidad.Persona:
                    entidadActualizada = BasesDatosHelper.EjecutarQuery(Persona.QueryActualizar(), Persona.Parametros(obj as Persona));
                    break;
                case TipoEntidad.Roles:
                    entidadActualizada = BasesDatosHelper.EjecutarQuery(Roles.QueryActualizar(), Roles.Parametros(obj as Roles));
                    break;
            }

            return entidadActualizada;
        }

        public bool EliminarEntidad<T>(int id)
        {
            bool entidadEliminada = false;
            switch (this.ObtenerTipo(typeof(T)))
            {
                case TipoEntidad.Persona:
                    entidadEliminada = BasesDatosHelper.EjecutarQuery(Persona.QueryEliminar(), Persona.Parametros(new Persona() { Id = id }));
                    if (entidadEliminada)
                    {
                        this.ListaPersonas.Remove(ListaPersonas.Where(x => x.Id == id).FirstOrDefault());
                    }
                    break;
                case TipoEntidad.Roles:
                    entidadEliminada = BasesDatosHelper.EjecutarQuery(Roles.QueryEliminar(), Roles.Parametros(new Roles(id)));
                    if (entidadEliminada)
                    {
                        this.ListaRoles.Remove(listaRoles.Where(x => x.Id == id).FirstOrDefault());
                    }
                    break;
            }

            return entidadEliminada;
        }

        public int ObtenerIdPorNombreEnLista<T>(string nombre)
        {
            switch (this.ObtenerTipo(typeof(T)))
            {
                case TipoEntidad.Persona:
                    return this.ListaPersonas.Where(x => x.Nombre == nombre).FirstOrDefault().Id;
                case TipoEntidad.Roles:
                    return this.ListaRoles.Where(x => x.Descripcion == nombre).FirstOrDefault().Id;
            }

            return 0;
        }

        private TipoEntidad ObtenerTipo(Type tipo)
        {
            if (tipo == typeof(Persona))
            {
                return TipoEntidad.Persona;
            }
            else
            {
                return TipoEntidad.Roles;
            }
        }

        public List<T> ObtenerListaEnum<T>() where T : struct
        {
            List<T> listaEnums = new List<T>();
            foreach (object item in Enum.GetValues(typeof(T)))
            {
                listaEnums.Add((T)item);
            }

            return listaEnums;
        }

        /// <summary>
        /// Método calcula los porcentajes. 
        /// </summary>
        public void CalcularResultados()
        {
            this.CalcularPerfiles();
            this.CalcularRoles();
        }
        private void CalcularPerfiles()
        {
            #region Calcula los numeros
            this.estadisticas.TotalHombresCis = listaPersonas.Count(x => x.Genero == Genero.HombreCis.ToString());
            this.estadisticas.TotalMujeresCis = listaPersonas.Count(x => x.Genero == Genero.MujerCis.ToString());
            this.estadisticas.TotalNoBinarie = listaPersonas.Count(x => x.Genero == Genero.NoBinarie.ToString());
            this.estadisticas.TotalHombresTrans = listaPersonas.Count(x => x.Genero == Genero.HombreTrans.ToString());
            this.estadisticas.TotalMujeresTrans = listaPersonas.Count(x => x.Genero == Genero.MujerTrans.ToString());
            this.estadisticas.TotalAgenero = listaPersonas.Count(x => x.Genero == Genero.Agenero.ToString());
            this.estadisticas.TotalEntre20y30 = listaPersonas.Count(x => x.Edad >= 20 && x.Edad <= 30);
            this.estadisticas.TotalEntre30y40 = listaPersonas.Count(x => x.Edad >= 30 && x.Edad <= 40);
            this.estadisticas.TotalEntre40y50 = listaPersonas.Count(x => x.Edad >= 40 && x.Edad <= 50);
            this.estadisticas.TotalMasDe50 = listaPersonas.Count(x => x.Edad > 50);
            #endregion

            #region Calcula los porcentajes
            this.estadisticas.PorcentajeHombresCis = (this.estadisticas.TotalHombresCis * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeMujeresCis = (this.estadisticas.TotalMujeresCis * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeNoBinarie = (this.estadisticas.TotalNoBinarie * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeHombresTrans = (this.estadisticas.TotalHombresTrans * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeMujeresTrans = (this.estadisticas.TotalMujeresTrans * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeAgenero = (this.estadisticas.TotalAgenero * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeEntre20y30 = (this.estadisticas.TotalEntre20y30 * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeEntre30y40 = (this.estadisticas.TotalEntre30y40 * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeEntre40y50 = (this.estadisticas.TotalEntre40y50 * 100) / this.TotalPersonas;
            this.estadisticas.PorcentajeMasDe50 = (this.estadisticas.TotalMasDe50 * 100) / this.TotalPersonas;
            #endregion
        }
        private void CalcularRoles()
        {
            if(this.TotalPersonas > 0)
            {
                var listaOrdenadaPuestos = listaPersonas.GroupBy(x => x.RolId).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).ToList();
                int idPuestoMejorPagado = listaPersonas.Where(x => x.Salario == listaPersonas.Max(x => x.Salario)).FirstOrDefault().RolId;
                int idPuestoPeorPagado = listaPersonas.Where(x => x.Salario == listaPersonas.Min(x => x.Salario)).FirstOrDefault().RolId;

                this.estadisticas.RolMasNumeroso = listaRoles.Where(x => x.Id == listaOrdenadaPuestos.First()).FirstOrDefault().Descripcion;
                this.estadisticas.RolMenosNumeroso = listaRoles.Where(x => x.Id == listaOrdenadaPuestos.Last()).FirstOrDefault().Descripcion;
                this.estadisticas.RolMejorPagado = listaRoles.Where(x => x.Id == idPuestoMejorPagado).FirstOrDefault().Descripcion;
                this.estadisticas.RolPeorPagado = listaRoles.Where(x => x.Id == idPuestoPeorPagado).FirstOrDefault().Descripcion;
            }
        }
    }
}