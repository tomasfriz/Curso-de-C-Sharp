using Microsoft.VisualStudio.TestTools.UnitTesting;
using Evento;

namespace TestEvento
{
    [TestClass]
    public class TesteoEvento
    {
        [TestMethod]
        public void Test1()
        {
            SuscriptorCalculadoraVirutal calculadoraVirutal = new SuscriptorCalculadoraVirutal(3, 2);
            calculadoraVirutal.ResultadoSuma();
            calculadoraVirutal.ResultadoResta();
        }
    }
}
