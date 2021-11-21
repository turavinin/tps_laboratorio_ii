using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Puesto
    {
        private int id;
        private string descripcion;


        public int Id { get => this.id; set => this.id = value > 0 ? value : 0; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }

        public Puesto() : this(0, string.Empty)
        {

        }

        public Puesto(int id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
    }
}
