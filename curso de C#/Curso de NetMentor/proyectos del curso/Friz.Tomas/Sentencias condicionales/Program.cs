using System;

namespace Sentencias_condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nombre: ");
            string nombre = Console.ReadLine();
            if(nombre == "Tomas")
            {
                Console.WriteLine("Hola Tomas.");
            }
            else if (nombre == "test")
            {
                Console.WriteLine("test");
            }
            else if (nombre == "test2")
            {
                Console.WriteLine("Buenos Dias");
            }
            else
            {
                Console.WriteLine("Hola desconocido.");
            }

            int edad = nombre == "Tomas" ? 22 : 10;
            Console.WriteLine("La edad es: " + edad);

            Console.WriteLine();
            //----------------------------------------------------------------

            Console.WriteLine("Escribe un mes: ");
            string mes = Console.ReadLine();
            switch (mes)
            {
                case "enero":
                case "marzo":
                case "mayo":
                case "julio":
                case "agosto":
                case "octubre":
                case "diciembre":
                    Console.WriteLine("este mes tiene 31 dias");
                    break;
                case "febrero":
                    Console.WriteLine("febrero tiene 28 dias");
                    break;
                case "abril":
                case "junio":
                case "septiembre":
                case "noviembre":
                    Console.WriteLine("este mes tiene 30 dias");
                    break;
                default:
                    Console.WriteLine("mes no encontrado");
                    break;
            }

            Console.WriteLine();
            //-------------------------------------------------------------------
            
            Console.WriteLine("Bucle For");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Iteración número " + i);
            }

            Console.WriteLine();
            //-------------------------------------------------------------------

            Console.WriteLine("Bucle while");
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine("Iteración número " + contador);
                contador++;
            }

            Console.WriteLine();
            //-------------------------------------------------------------------

            Console.WriteLine("Bucle do-while");
            int cont = 0;
            do
            {
                Console.WriteLine("Iteración número " + cont);
                cont++;
            } while (cont < 10);
        }
    }
}
