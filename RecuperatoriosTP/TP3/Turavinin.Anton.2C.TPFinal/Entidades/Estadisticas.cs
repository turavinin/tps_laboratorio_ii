using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadisticas
    {
        #region Atributos
        private string rolMasNumeroso;
        private string rolMenosNumeroso;
        private string rolMejorPagado;
        private string rolPeorPagado;
        private int totalHombresCis;
        private int porcentajeHombresCis;
        private int totalMujeresCis;
        private int porcentajeMujeresCis;
        private int totalNoBinarie;
        private int porcentajeNoBinarie;
        private int totalHombresTrans;
        private int porcentajeHombresTrans;
        private int totalMujeresTrans;
        private int porcentajeMujeresTrans;
        private int totalAgenero;
        private int porcentajeAgenero;
        private int totalEntre20y30;
        private int porcentajeEntre20y30;
        private int totalEntre30y40;
        private int porcentajeEntre30y40;
        private int totalEntre40y50;
        private int porcentajeEntre40y50;
        private int totalMasDe50;
        private int porcentajeMasDe50; 
        #endregion

        #region Propiedades
        public string RolMasNumeroso { get => this.rolMasNumeroso; set => this.rolMasNumeroso = value; }
        public string RolMenosNumeroso { get => this.rolMenosNumeroso; set => this.rolMenosNumeroso = value; }
        public string RolMejorPagado { get => this.rolMejorPagado; set => this.rolMejorPagado = value; }
        public string RolPeorPagado { get => this.rolPeorPagado; set => this.rolPeorPagado = value; }
        public int TotalHombresCis { get => totalHombresCis; set => totalHombresCis = value; }
        public int PorcentajeHombresCis { get => porcentajeHombresCis; set => porcentajeHombresCis = value; }
        public int TotalMujeresCis { get => totalMujeresCis; set => totalMujeresCis = value; }
        public int PorcentajeMujeresCis { get => porcentajeMujeresCis; set => porcentajeMujeresCis = value; }
        public int TotalNoBinarie { get => totalNoBinarie; set => totalNoBinarie = value; }
        public int PorcentajeNoBinarie { get => porcentajeNoBinarie; set => porcentajeNoBinarie = value; }
        public int TotalHombresTrans { get => totalHombresTrans; set => totalHombresTrans = value; }
        public int PorcentajeHombresTrans { get => porcentajeHombresTrans; set => porcentajeHombresTrans = value; }
        public int TotalMujeresTrans { get => totalMujeresTrans; set => totalMujeresTrans = value; }
        public int PorcentajeMujeresTrans { get => porcentajeMujeresTrans; set => porcentajeMujeresTrans = value; }
        public int TotalAgenero { get => totalAgenero; set => totalAgenero = value; }
        public int PorcentajeAgenero { get => porcentajeAgenero; set => porcentajeAgenero = value; }
        public int TotalEntre20y30 { get => totalEntre20y30; set => totalEntre20y30 = value; }
        public int PorcentajeEntre20y30 { get => porcentajeEntre20y30; set => porcentajeEntre20y30 = value; }
        public int TotalEntre30y40 { get => totalEntre30y40; set => totalEntre30y40 = value; }
        public int PorcentajeEntre30y40 { get => porcentajeEntre30y40; set => porcentajeEntre30y40 = value; }
        public int TotalEntre40y50 { get => totalEntre40y50; set => totalEntre40y50 = value; }
        public int PorcentajeEntre40y50 { get => porcentajeEntre40y50; set => porcentajeEntre40y50 = value; }
        public int TotalMasDe50 { get => totalMasDe50; set => totalMasDe50 = value; }
        public int PorcentajeMasDe50 { get => porcentajeMasDe50; set => porcentajeMasDe50 = value; }
        #endregion
    }
}
