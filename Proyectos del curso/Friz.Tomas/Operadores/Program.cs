using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores relacionales

            double pesoTest;

            Console.Write("Digita tu peso: ");
            pesoTest = Convert.ToDouble(Console.ReadLine());

            if (pesoTest <= 100)
            {
                Console.WriteLine("Cumple con la condicion 1");
            }
            if (pesoTest >= 100)
            {
                Console.WriteLine("Cumple con la condicion 2");
            }
            if (pesoTest == 100)
            {
                Console.WriteLine("Cumple con la condicion 3");
            }
            if (pesoTest != 100)
            {
                Console.WriteLine("Cumple con la condicion 4");
            }
            
            //------------------------------------------------------------------

            //Operadores logicos

            double peso;
            byte edad;

            Console.Write("Digita tu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digita tu edad: ");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();

            if (peso > 100 && edad >= 15)
            {
                Console.WriteLine("Tu peso es normal");
            }

            //if (peso > 100 || edad >= 15)
            //{
            //    Console.WriteLine("Tu peso es normal");
            //}
        }
    }
}
