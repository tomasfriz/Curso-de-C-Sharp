using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    public class Ejemplo
    {
        /// <summary>
        /// uso de Invariance.
        /// </summary>
        /// <param name="personas"></param>
        public static void Imprimir(List<Persona> personas)
        {
            foreach (var persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo {persona.GetType().ToString()}");
            }
        }
        /// <summary>
        /// uso de Covariance.
        /// </summary>
        /// <param name="personas"></param>
        public static void ImprimirPersonas(IEnumerable<Persona> personas)
        {
            foreach (var persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo {persona.GetType().ToString()}");
            }
        }

        public static void RealizarActionBecario(Action<Becario> becarioAction)
        {
            Becario becario = new Becario();
            becarioAction(becario);
        }
    }
}
