using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate void ImprimirDelegado<T>(T value);

    public class DelegadosConGenerics
    {
        private void Imprimir(string valor)
        {
            Console.WriteLine(valor);
        }

        private void Imprimir(int valor)
        {
            Console.WriteLine($"el valor es {valor}");
        }

        public void EjemploDelegate()
        {
            //Declaración
            ImprimirDelegado<string> imprimirDelegado = new ImprimirDelegado<string>(Imprimir);
            ImprimirDelegado<int> imprimirDelegadoEntero = new ImprimirDelegado<int>(Imprimir);

            //invocación
            imprimirDelegado("texto de ejemplo");
            imprimirDelegadoEntero(25);
        }
    }
}
