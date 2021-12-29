using System;

namespace OperadoresArimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores Arimeticos

            int num1 = 6, num2 = 5;

            Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
            Console.WriteLine("El resultado de la multiplicacion es: " + (num1 * num2));
            Console.WriteLine("El resultado de la division es: " + (num1 / num2));
            Console.WriteLine("El resultado de el resto es: " + (num1 % num2));

            double num, pot, rta;

            Console.Write("Digite el numero que quiere elevar: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a la potencia que quiere elevar: ");
            pot = Convert.ToDouble(Console.ReadLine());

            rta = Math.Pow(num, pot);

            Console.WriteLine("El resultado es: " + rta);

            Console.WriteLine("La raiz cuadrada es: " + Math.Sqrt(49));
        }
    }
}
