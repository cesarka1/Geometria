using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometriaAPI.Models;
namespace GeometriaTest
{
    [TestClass]
    public class TrapezioTest
    {
        [TestMethod]
        public void TrapezioCalcularArea()
        {
            Trapezio trapezio = new Trapezio();
            double esperado = 4;
            string[] medidas = {"2", "2", "2"};
            double resultado = trapezio.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void TrapezioCalcularPerimetro()
        {
            Trapezio trapezio = new Trapezio();
            double esperado = 8;
            string[] medidas ={"2","2","2","2"};
            double resultado = trapezio.CalcularPerimetro(medidas);
            Assert.AreEqual(esperado, resultado);
        }
    }
}