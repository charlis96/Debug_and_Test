using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        [Test]
        public void CreatePersonWithNameAndIdTest() // Cambiá el nombre para indicar qué estás probando
        {
            // Configuración
            const string expectedID = "12345672";
            const string expectedName = "Test Name";
            const string idOK = "12345672";
            // Ejecución
            Person person = new Person(expectedName, idOK);
            // Comprobación
            Assert.AreEqual(expectedID, person.ID);
            Assert.AreEqual(expectedName, person.Name);
        }

        [Test]
        public void CreatePersonWithNameAndIncorrectIdTest() // Cambiá el nombre para indicar qué estás probando
        {
            // Configuración
            const string expectedID = null;
            const string expectedName = "Test Name";
            const string wrongId = "4.753.174-6";
            // Ejecución
            Person person = new Person(expectedName, wrongId);
            // Comprobación
            Assert.AreEqual(expectedID, person.ID);
            Assert.AreEqual(expectedName, person.Name);
        }
    }
}