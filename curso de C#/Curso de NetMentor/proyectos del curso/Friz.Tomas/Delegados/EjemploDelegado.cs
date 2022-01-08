using System;

namespace Delegados
{
    public delegate void ImprimirDelegado(string value);
    public class EjemploDelegado
    {
        private void Imprimir(string valor)
        {
            Console.WriteLine(valor);
        }

        public void EjemploDelegate()
        {
            //Declaración
            ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir);

            //invocación
            imprimirDelegado("texto de ejemplo");
        }

    }
}
