using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_y_operadores
{
    public class Operadores_de_asignación
    {
        public string AsignarValor()
        {
            string frase = "Asignamos valor con =";
            return frase;
        }
        public int Incremento(int num)
        {
            return num++;
        }
        public int Decremento(int num)
        {
            return num--;
        }
        public void EjemploIncrementoDetras(int num)
        {
            Console.WriteLine(num++);
        }
        public void EjemploIncrementoDelante(int num)
        {
            Console.WriteLine(++num);
        }
    }
}
