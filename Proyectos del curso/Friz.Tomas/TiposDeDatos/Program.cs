using System;

namespace TiposDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 - 255
            byte var1 = 230;
            Console.WriteLine("El valor de la variable es: " + var1);

            // Enteras -2147,483,648 al 2147,483,647
            int var2 = 2147483647;
            Console.WriteLine("El valor de la variable es: " + var2);

            // Double
            double var3 = 56.78;
            Console.WriteLine("El valor de la variable es: " + var3);

            // Booleano
            bool var4 = true;
            Console.WriteLine("El valor de la variable es: " + var4);

            // Character
            char var5 = 'C';
            Console.WriteLine("El valor de la variable es: " + var5);

            // String
            String var6 = "Es una cadena";
            Console.WriteLine("El valor de la variable es: " + var6);

            // Dynamic
            dynamic var7 = 23;
            dynamic var8 = "Es una cadena";
            dynamic var9 = 'C';
            Console.WriteLine("El valor de la variable es: " + var7);
            Console.WriteLine("El valor de la variable es: " + var8);
            Console.WriteLine("El valor de la variable es: " + var9);
        }
    }
}
