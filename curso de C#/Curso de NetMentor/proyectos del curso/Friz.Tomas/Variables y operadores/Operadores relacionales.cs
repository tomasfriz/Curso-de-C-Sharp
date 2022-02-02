using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_y_operadores
{
    public class Operadores_relacionales
    {
        public bool MayorQue(int num1, int num2)
        {
            return num1 > num2;
        }
        public bool MayorIgualQue(int num1, int num2)
        {
            return num1 >= num2;
        }
        public bool MenorQue(int num1, int num2)
        {
            return num1 < num2;
        }
        public bool MenorIgualQue(int num1, int num2)
        {
            return num1 <= num2;
        }
        public bool IgualQue(int num1, int num2)
        {
            return num1 == num2;
        }
        public bool DistintoQue(int num1, int num2)
        {
            return num1 != num2;
        }
    }
}
