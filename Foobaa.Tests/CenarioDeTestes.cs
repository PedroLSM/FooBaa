using TDDExemplo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Foobaa.Tests
{
    [TestClass]
    public class CenarioDeTestes
    {
        [TestMethod]
        public void QuandoPassar3RetornarFoo()
        {
            // Arrange
            ConversorFooBaa cfb = new ConversorFooBaa();
            int num = 3;

            //Act
            string resultado = cfb.ConverterMutiplo(num);

            //Assert
            Assert.AreEqual("foo", resultado);
        }

        [TestMethod]
        public void QuandoPassar5RetornarBaa()
        {
            // Arrange
            ConversorFooBaa cfb = new ConversorFooBaa();
            int num = 5;

            //Act
            string resultado = cfb.ConverterMutiplo(num);

            //Assert
            Assert.AreEqual("baa", resultado);
        }

        [TestMethod]
        public void QuandoPassar15RetornarFooBaa()
        {
            // Arrange
            ConversorFooBaa cfb = new ConversorFooBaa();
            int num = 15;

            //Act
            string resultado = cfb.ConverterMutiplo(num);

            //Assert
            Assert.AreEqual("foobaa", resultado);
        }

        [TestMethod]
        public void QuandoPassar7RetornarNada()
        {
            // Arrange
            ConversorFooBaa cfb = new ConversorFooBaa();
            int num = 7;

            //Act
            string resultado = cfb.ConverterMutiplo(num);

            //Assert
            Assert.AreEqual("", resultado);
        }
        
    }
}
