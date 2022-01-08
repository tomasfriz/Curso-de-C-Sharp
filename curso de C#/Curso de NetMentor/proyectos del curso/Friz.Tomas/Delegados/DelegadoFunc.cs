using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class DelegadoFunc
    {
        public void EjemploFunc()
        {
            Func<int, string> resultado = v => $"el resultado es {v}";
            Console.WriteLine(resultado(5));

            Func<int, int, int> multiplicacion = (v1, v2) => v1 * v2;
            int valor = multiplicacion(3, 2);
            Console.WriteLine($"El resultado es {valor}");
        }
    }
}
