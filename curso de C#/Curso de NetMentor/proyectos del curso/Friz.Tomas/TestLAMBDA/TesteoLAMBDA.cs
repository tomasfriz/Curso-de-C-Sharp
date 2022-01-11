using Microsoft.VisualStudio.TestTools.UnitTesting;
using Expresiones_Lambda;

namespace TestLAMBDA
{
    [TestClass]
    public class TesteoLAMBDA
    {
        [TestMethod]
        public void Test1()
        {
            EjemploLambda ejemploLambda = new EjemploLambda();
            var result = ejemploLambda.TestLambda();
            Assert.AreEqual(2, result);
        }
    }
}
