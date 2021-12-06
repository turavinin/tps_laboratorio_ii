using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestObtenerIdPorNombreEnLista()
        {
            //ARRENGE
            Manager manager = new Manager();
            manager.ListaPersonas.Add(new Persona(1, "Persona1", 22, Genero.MujerCis.ToString(), 1, Experiencia.Junior.ToString(), 20000));
            manager.ListaPersonas.Add(new Persona(2, "Persona2", 22, Genero.MujerCis.ToString(), 1, Experiencia.Junior.ToString(), 20000));
            int idDePersonaAEncontrar = manager.ListaPersonas[1].Id;

            //ACT
            int idPErsonaEncontrada = manager.ObtenerIdPorNombreEnLista<Persona>("Persona2");

            //ASSERT
            Assert.AreEqual(idPErsonaEncontrada, idDePersonaAEncontrar);
        }


        [TestMethod]
        public void TestRolMejorPago()
        {
            //ARRENGE
            Manager manager = new Manager();
            manager.ListaPersonas.Add(new Persona(1, "Persona1", 22, Genero.MujerCis.ToString(), 1, Experiencia.Junior.ToString(), 10000));
            manager.ListaPersonas.Add(new Persona(2, "Persona2", 22, Genero.MujerCis.ToString(), 2, Experiencia.Junior.ToString(), 30000));
            manager.ListaRoles.Add(new Roles(1, "Developer"));
            manager.ListaRoles.Add(new Roles(2, "QA"));
            string rolMejorPago = "QA";

            //ACT
            manager.CalcularResultados();

            //ASSERT
            Assert.AreEqual(rolMejorPago, manager.Estadisticas.RolMejorPagado);
        }
    }
}
