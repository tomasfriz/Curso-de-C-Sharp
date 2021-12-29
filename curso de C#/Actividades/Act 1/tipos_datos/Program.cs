using System;

namespace tipos_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic num1 = 100;
            dynamic num2 = 15.50;
            int num3 = 50;
            double num4 = 100.50;
            float num5 = 5.5f;
            bool estado = true;
            char letra = 'T';
            string palabra = "Hola Mundo";

            Console.WriteLine("La variable num1 contiene el número: " + num1);
            Console.WriteLine("La variable num2 contiene el número: " + num2);
            Console.WriteLine("La variable num3 contiene el número: " + num3);
            Console.WriteLine("La variable num4 contiene el número: " + num4);
            Console.WriteLine("La variable num5 contiene el número: " + num5);
            Console.WriteLine("La variable estado contiene el estado: " + estado);
            Console.WriteLine("La variable letra contiene la letra: " + letra);
            Console.WriteLine("La variable palabra contiene la frase: " + palabra);

            Console.ReadKey();
        }
    }
}
