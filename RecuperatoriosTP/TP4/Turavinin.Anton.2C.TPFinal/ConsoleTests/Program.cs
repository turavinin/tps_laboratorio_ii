using Entidades;
using System;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.ListaPersonas.Add(new Persona(1, "Persona1", 22, Genero.MujerCis.ToString(), 1, Experiencia.Junior.ToString(), 10000));
            manager.ListaPersonas.Add(new Persona(2, "Persona2", 22, Genero.MujerCis.ToString(), 2, Experiencia.Junior.ToString(), 30000));
            manager.ListaRoles.Add(new Roles(1, "Developer"));
            manager.ListaRoles.Add(new Roles(2, "QA"));


            // PRUEBA ENCONTRAR REGISTRO EN LISTA
            int idDePersonaAEncontrar = manager.ListaPersonas[1].Id;
            int idPErsonaEncontrada = manager.ObtenerIdPorNombreEnLista<Persona>("Persona2");
            Console.WriteLine($"El ID de la persona debe ser {idDePersonaAEncontrar}, y es: {idPErsonaEncontrada}");

            // ENCONTRAR ROL MEJOR PAGO
            string rolMejorPago = "QA";
            manager.CalcularResultados();
            Console.WriteLine($"El ID de la persona debe ser {rolMejorPago}, y es: {manager.Estadisticas.RolMejorPagado}");



            Console.ReadLine();
        }
    }
}
