using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class DelegadosAnónimos
    {
        public void EjemploActionAnonimo()
        {
            Action<string> imprimirAction = delegate (string valor)
            {
                Console.WriteLine(valor);
            };

            imprimirAction("ejemplo");

            Action<string> imprimirActionLambda = v => Console.WriteLine(v);

            imprimirActionLambda("ejemplo Lambda");
        }
    }
}
