using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadisticasPuestos
    {
        private int totalPuestos;
        private string puestoMasNumeroso;
        private string puestoMenosNumeroso;
        private string puestoMejorPagado;
        private string puestoPeorPagado;


        public int TotalPuestos { get => this.totalPuestos; set => this.totalPuestos = value; }
        public string PuestoMasNumeroso { get => this.puestoMasNumeroso; set => this.puestoMasNumeroso = value; }
        public string PuestoMenosNumeroso { get => this.puestoMenosNumeroso; set => this.puestoMenosNumeroso = value; }
        public string PuestoMejorPagado { get => this.puestoMejorPagado; set => this.puestoMejorPagado = value; }
        public string PuestoPeorPagado { get => this.puestoPeorPagado; set => this.puestoPeorPagado = value; }

    }
}
