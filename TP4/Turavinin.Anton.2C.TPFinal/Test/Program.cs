using Entidades;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EncuestaManager _manager = new EncuestaManager();

            _manager.Puestos.Add(new Puesto(1, "Web Developer"));
            _manager.Puestos.Add(new Puesto(2, "QA Tester"));

            _manager.Experiencias.Add(new Experiencia(1, "Junior"));
            _manager.Experiencias.Add(new Experiencia(2, "Semi-Senior"));

            _manager.Personas.Add(new Persona(1, "Andres", 20, "Hombre Cis", 1, 1, 20000));
            _manager.Personas.Add(new Persona(2, "Julia", 21, "Mujer Cis", 2, 2, 30000));

            // Prueba encontrar registro
            Persona personaEncontrada = _manager.EncontrarRegistro<Persona>(1);
            Console.WriteLine($"El nombre de la persona encontrada debe ser Andres, y es: {personaEncontrada.Nombre}");
            Console.WriteLine();

            // Encontrar siguiente ID
            int siguienteId = _manager.ObtenerSiguienteId<Persona>();
            Console.WriteLine($"El siguiente Id debe ser 3, y es: {siguienteId}");
            Console.WriteLine();

            // Prueba estadisticas
            _manager.CalcularPerfilPersonas();
            _manager.EstablecerEstadisticasPuestos();
            Console.WriteLine($"El puesto con mejor salario debe ser QA Tester, y es: {_manager.EstadisticaPuestos.PuestoMejorPagado}");
            Console.WriteLine($"El porcentaje de Hombre Cis debe ser del 50%, y es: {_manager.PerfilPersonas.PorcentajeHombresCis}%");
            Console.WriteLine();



            Console.ReadLine();
        }
    }
}
