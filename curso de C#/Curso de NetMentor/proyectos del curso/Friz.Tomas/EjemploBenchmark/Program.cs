using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Running; //Sirve para el rendimiento de las aplicaciones.
using BenchmarkDotNet.Reports; //en otras palabras para que valla mas rapido el codigo.
using BenchmarkDotNet.Attributes; //estos tres using son necesarios para el funcionamiento de este nuget.
// el objetivo de Benchmark es para testear cual metodo va mas rapido, ademas no puede usar metodos con parametro o metodos dinamicos y se tiene que ejecutar en Release y no en Debug.

namespace EjemploBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Summary summary = BenchmarkRunner.Run<Ejemplo>();

            Console.WriteLine(summary);
        }
    }

    public class Ejemplo
    {
        public IList<long> Items { get; set; }
        public IList<long> ItemsList2 { get; set; }

        public Ejemplo()
        {
            Items = Enumerable.Range(1, 1000000).Select(a => Convert.ToInt64(a)).ToList();
            ItemsList2 = Enumerable.Range(1, 1000000 - 1).Select(a => Convert.ToInt64(a)).ToList();
            ItemsList2.Add(1);
        }

        [Benchmark]
        public void BenchmarkGenericEquals()
        {
            _ = EqualsGeneric(Items, ItemsList2);
        }

        [Benchmark]
        public void BenchmarkLongEquals()
        {
            _ = EqualsLong(Items, ItemsList2);
        }

        public bool EqualsGeneric(IList<long> x, IList<long> y)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;
            if (x.Count != y.Count)
                return false;
            for (var i = 0; i < x.Count; i++)
            {
                if (x[i] == null)
                {
                    if (y[i] != null)
                        return false;
                }
                else if (!x[i].Equals(y[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool EqualsLong(IList<long> x, IList<long> y)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null))
                return false;
            if (x.Count != y.Count)
                return false;
            for (var i = 0; i < x.Count; i++)
            {
                if (!x[i].Equals(y[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
