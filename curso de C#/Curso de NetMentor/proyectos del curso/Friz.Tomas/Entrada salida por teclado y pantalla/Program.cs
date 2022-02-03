using System;

namespace Entrada_salida_por_teclado_y_pantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Introudce tu nombre: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine($"El nombre es {nombre}");

            //Console.Write("Por favor introduce tu edad: ");
            //string entradaTeclado = Console.ReadLine();
            //int edad = int.Parse(entradaTeclado);
            //Console.WriteLine("El doble de tu edad es: " + edad * 2);

            //Console.Write("Introudce un caracter: ");
            //int caracter = Console.Read();
            //Console.WriteLine("El valor ASCII es: " + caracter);

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("{0,5} {1,5}", 123, 456);

            //----------------------------------------------------------------

            /*  Diferencia entre la edad de nuestro padre y la nuestra.
             *  Entrar nuestra edad, la edad del padre
             *  edadPadre - edadHijo
             *  mostrar la edad del padre es X años y la edad del hijo Y
             *  lo que significa una diferencia de Z años.
            */

            Console.Write("Por favor introduce tu edad: ");
            string edadHijo = Console.ReadLine();
            Console.Write("Por favor introduce la edad de tu padre: ");
            string edadPadre = Console.ReadLine();

            int diferenciaEdad = int.Parse(edadPadre) - int.Parse(edadHijo);

            Console.WriteLine("La diferencia de edad es: " + diferenciaEdad + " años");
            Console.WriteLine("La diferencia de edad es: {0} años", diferenciaEdad);
        }
    }
}
