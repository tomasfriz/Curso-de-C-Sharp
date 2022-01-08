using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delegados;

namespace TestDelegado
{
    [TestClass]
    public class TesteoDelegados
    {
        [TestMethod]
        public void Test1()
        {
            EjemploDelegado del = new();
            del.EjemploDelegate();
        }

        [TestMethod]
        public void Test2()
        {
            DelegadosConGenerics del = new();
            del.EjemploDelegate();
        }

        [TestMethod]
        public void Test3()
        {
            DelegadoAction del = new();
            del.EjemploAction();
        }

        [TestMethod]
        public void Test4()
        {
            DelegadosAnónimos del = new();
            del.EjemploActionAnonimo();
        }

        [TestMethod]
        public void Test5()
        {
            DelegadoFunc del = new();
            del.EjemploFunc();
        }

        [TestMethod]
        public void Test6()
        {
            DelegadoPredicate del = new();
            del.EjemploPredicate();
        }
    }
}
