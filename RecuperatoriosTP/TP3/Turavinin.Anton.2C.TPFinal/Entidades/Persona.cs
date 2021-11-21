using System;
using System.Collections.Generic;
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

    }
}
