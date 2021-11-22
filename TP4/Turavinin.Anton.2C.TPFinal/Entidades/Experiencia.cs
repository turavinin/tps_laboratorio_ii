using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Experiencia
    {
        private int id;
        private string tipoExperiencia;


        public int Id { get => this.id; set => this.id = value > 0 ? value : 0; }
        public string TipoExperiencia { get => this.tipoExperiencia; set => this.tipoExperiencia = !string.IsNullOrWhiteSpace(value) ? value : string.Empty; }


        public Experiencia() : this(0, string.Empty)
        {

        }
        public Experiencia(int id, string tipoExperiencia)
        {
            this.Id = id;
            this.TipoExperiencia = tipoExperiencia;
        }
    }
}
