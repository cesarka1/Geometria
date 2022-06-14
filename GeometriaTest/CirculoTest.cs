using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;
namespace GeometriaTest
{
    [TestClass]
    public class CirculoTest
    {
        [TestMethod]
        public void CirculoCalcularArea()
        {
            Circulo circulo = new Circulo();
            double esperado = 3.14;
            string[] medidas = {"10"};
            double resultado = circulo.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void CirculoCalcularPerimetro()
        {
            Circulo circulo = new Circulo();
            double esperado = 6.28;
            string[] medidas ={"10"};
            double resultado = circulo.CalcularPerimetro(medidas);
            Assert.AreEqual(esperado, resultado);
        }
    }
}