using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Covariance;
using System;

namespace TestCovariance
{
    [TestClass]
    public class testeoCovariance
    {
        [TestMethod]
        public void Test1()
        {
            List<Persona> personas = new List<Persona>()
            {
                new Becario(),
                new Jefe()
            };
            Ejemplo.Imprimir(personas);
        }

        [TestMethod]
        public void Test2()
        {
            List<Jefe> jefe = new List<Jefe>()
            {
                new Jefe(),
                new Jefe()
            };
            Ejemplo.ImprimirPersonas(jefe);
        }

        [TestMethod]
        public void Test3()
        {
            var accionBecario = new Action<Becario>(z => Console.WriteLine("Preparo el café"));
            Ejemplo.RealizarActionBecario(accionBecario);

            var accionEmpleado = new Action<Empleado>(z => Console.WriteLine("trabajo duro"));
            Ejemplo.RealizarActionBecario(accionEmpleado);
        }
    }
}
