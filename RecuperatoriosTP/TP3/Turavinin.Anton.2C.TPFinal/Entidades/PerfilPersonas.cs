using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PerfilPersonas
    {
        private int totalPersonas;

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


        public int TotalPersonas { get => totalPersonas; set => totalPersonas = value; }

        public int TotalHombresCis { get => totalHombresCis; set => totalHombresCis = value; }
        public int PorcentajeHombresCis { get => porcentajeHombresCis; private set => porcentajeHombresCis = value; }

        public int TotalMujeresCis { get => totalMujeresCis; set => totalMujeresCis = value; }
        public int PorcentajeMujeresCis { get => porcentajeMujeresCis; private set => porcentajeMujeresCis = value; }

        public int TotalNoBinarie { get => totalNoBinarie; set => totalNoBinarie = value; }
        public int PorcentajeNoBinarie { get => porcentajeNoBinarie; private set => porcentajeNoBinarie = value; }

        public int TotalHombresTrans { get => totalHombresTrans; set => totalHombresTrans = value; }
        public int PorcentajeHombresTrans { get => porcentajeHombresTrans; private set => porcentajeHombresTrans = value; }

        public int TotalMujeresTrans { get => totalMujeresTrans; set => totalMujeresTrans = value; }
        public int PorcentajeMujeresTrans { get => porcentajeMujeresTrans; private set => porcentajeMujeresTrans = value; }

        public int TotalAgenero { get => totalAgenero; set => totalAgenero = value; }
        public int PorcentajeAgenero { get => porcentajeAgenero; private set => porcentajeAgenero = value; }

        public int TotalEntre20y30 { get => totalEntre20y30; set => totalEntre20y30 = value; }
        public int PorcentajeEntre20y30 { get => porcentajeEntre20y30; private set => porcentajeEntre20y30 = value; }

        public int TotalEntre30y40 { get => totalEntre30y40; set => totalEntre30y40 = value; }
        public int PorcentajeEntre30y40 { get => porcentajeEntre30y40; private set => porcentajeEntre30y40 = value; }

        public int TotalEntre40y50 { get => totalEntre40y50; set => totalEntre40y50 = value; }
        public int PorcentajeEntre40y50 { get => porcentajeEntre40y50; private set => porcentajeEntre40y50 = value; }

        public int TotalMasDe50 { get => totalMasDe50; set => totalMasDe50 = value; }
        public int PorcentajeMasDe50 { get => porcentajeMasDe50; private set => porcentajeMasDe50 = value; }


        public void CalcularPorcentajes()
        {
            this.PorcentajeHombresCis = (this.TotalHombresCis * 100) / this.TotalPersonas;
            this.PorcentajeMujeresCis = (this.TotalMujeresCis * 100) / this.TotalPersonas;
            this.PorcentajeNoBinarie = (this.TotalNoBinarie * 100) / this.TotalPersonas;
            this.PorcentajeHombresTrans = (this.TotalHombresTrans * 100) / this.TotalPersonas;
            this.PorcentajeMujeresTrans = (this.TotalMujeresTrans * 100) / this.TotalPersonas;
            this.PorcentajeAgenero = (this.TotalAgenero * 100) / this.TotalPersonas;

            this.PorcentajeEntre20y30 = (this.TotalEntre20y30 * 100) / this.TotalPersonas;
            this.PorcentajeEntre30y40 = (this.TotalEntre30y40 * 100) / this.TotalPersonas;
            this.PorcentajeEntre40y50 = (this.TotalEntre40y50 * 100) / this.TotalPersonas;
            this.PorcentajeMasDe50 = (this.TotalMasDe50 * 100) / this.TotalPersonas;
        }
    }
}
