using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduccion_a_la_programacion
{
    class Vehiculo
    {
        public decimal VelocidadMaxima { get; set; }
        public decimal ConsumoPorKilometro { get; set; }

        //comentario de línea

        /*
            Comentario de bloque
        */

        /// Modificadores:
        /// public, sin restricciones.
        /// internal, solo se puede acceder a ellos desde el mismo proyecto.
        /// private, solo accesible desde la clase en la que se genera.
        /// protected, desde la propia clase y desde las derivada.

        public Vehiculo(decimal velocidadMaxima, decimal consumoPorKilometro)
        {
            VelocidadMaxima = velocidadMaxima;
            ConsumoPorKilometro = consumoPorKilometro;
        }
        /// <summary>
        /// Indica la cantidad de litros de gasolina gastados 
        /// </summary>
        /// <param name="kilometros">Indicar kilometros realizados</param>
        /// <returns></returns>
        public decimal ConsumoTotal(decimal kilometros)
        {
            return ConsumoPorKilometro * kilometros;
        }
    }
}
