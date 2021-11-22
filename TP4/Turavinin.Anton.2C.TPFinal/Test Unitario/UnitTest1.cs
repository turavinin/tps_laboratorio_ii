using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestObtenerIdPorNombreEnLista()
        {
            //ARRENGE
            EncuestaManager manager = new EncuestaManager();
            manager.Personas.Add(new Persona(1, "Persona1", 22, "Hombre Cis", 1, 2, 20000));
            manager.Personas.Add(new Persona(2, "Persona2", 22, "Mujer Cis", 1, 2, 20000));
            int idDePersonaAEncontrar = manager.Personas[1].Id;

            //ACT
            int idPErsonaEncontrada = manager.GetIdByNombreLista<Persona>("Persona2");

            //ASSERT
            Assert.AreEqual(idPErsonaEncontrada, idDePersonaAEncontrar);
        }


        [TestMethod]
        public void TestEncontrarEnListPorId()
        {
            //ARRENGE
            EncuestaManager manager = new EncuestaManager();
            manager.Personas.Add(new Persona(1, "Persona1", 22, "Hombre Cis", 1, 2, 20000));
            manager.Personas.Add(new Persona(2, "Persona2", 22, "Mujer Cis", 1, 2, 20000));
            Persona personaAEncontrar = manager.Personas[1];

            //ACT
            Persona personaEncontrada = manager.EncontrarRegistroLista<Persona>(2);

            //ASSERT
            Assert.AreEqual(personaAEncontrar, personaEncontrada);
        }
    }
}
