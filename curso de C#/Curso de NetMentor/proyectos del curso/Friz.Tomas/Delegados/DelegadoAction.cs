using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class DelegadoAction
    {
        private void Imprimir(string valor)
        {
            Console.WriteLine(valor);
        }

        public void EjemploAction()
        {
            Action<string> imprimirAction = Imprimir;
            imprimirAction("ejemplo");
        }
    }
}
