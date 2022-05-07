using Microsoft.VisualStudio.TestTools.UnitTesting;
using Example_of_TDD;

namespace Pruebas_Factorial
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Facorial_Of_Zero()
        {

            //Arrange
            FactorialService service = new FactorialService();


            //Act
            int resultado = service.Calculate(0);


            //Assert
            Assert.AreEqual(1, resultado);
        }
        [TestMethod]
        public void Factorial_Of_Five()
        {

            //Arrange
            FactorialService service = new FactorialService();


            //Act
            int resultado = service.Calculate(5);


            //Assert
            Assert.AreEqual(120, resultado);
        }
    }
}