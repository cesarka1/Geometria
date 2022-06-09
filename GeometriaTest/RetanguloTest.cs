using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GeometriaTest
{
    [TestClass]
    public class RetanguloTest
    {
        Retangulo retangulo = new Retangulo();
        [TestMethod]
        public void RetanguloCalcularAreaTestAccept()
        {
            double esperado = 20;
            string[] medidas = {"4", "5"};
            double resultado = retangulo.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void RetanguloCalcularAreaTestcomtexto()
        {
            double esperado = -1;
            string[] medidas = {"m", "5"};
            double resultado = retangulo.CalcularArea(medidas);
            Assert.AreEqual(esperado, resultado);
        }


    }
}
