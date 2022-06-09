using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;
namespace GeometriaTest
{
    [TestClass]
    public class TrianguloTest
    {
        [TestMethod]
        public void TrianguloCalcularAreaTestAccept()
        {
            Triangulo triangulo = new Triangulo();
            double esperado = 8;
            string[] medidas = {"4", "5"};
            double resultado = triangulo.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }
    }
}