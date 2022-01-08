using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public class DelegadoPredicate
    {
        public void EjemploPredicate()
        {
            Predicate<int> mayorDeEdad = e => e >= 18;
            bool esMayorDeEdad = mayorDeEdad(10);
            Console.WriteLine(esMayorDeEdad ? "es mayor de edad" : "no es mayor de edad");
        }
    }
}
