using System;

namespace Variables_y_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Declaración de variables.
            int ejemploVariable;
            ejemploVariable = 5;

            //Segunda forma
            int ejemploVariable2 = 5;

            //-------------------------------------------------------------------------------------

            //Tipo implícito de variables.
            var ejemploVariable3 = 5;

            //-------------------------------------------------------------------------------------


            //Declaración de constantes.
            DiasSemanas diasSemanas = DiasSemanas.Lunes;

            int[] array = new int[5];

            string myString = "valor";

            DateTime tiempo = new DateTime(1999, 07, 05);

            //------------------------------------------------------------------------------------

            // Operadores.
            Operadores_de_asignación operadoresDeAsignación = new Operadores_de_asignación();
            operadoresDeAsignación.EjemploIncrementoDelante(1); //2
            operadoresDeAsignación.EjemploIncrementoDetras(1); //1

        }
    }
}
