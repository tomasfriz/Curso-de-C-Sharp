using System;

namespace Evento
{
    public class EditorCalculadora
    {
        public delegate void EjemploDelegado();
        public event EjemploDelegado ejemploEvento;

        public void sumar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine("La suma es: {0}", a + b);
            }
            else
            {
                Console.WriteLine("No estas suscrito a los eventos");
            }
        }

        public void Restar(int a, int b)
        {
            if (ejemploEvento != null)
            {
                ejemploEvento();
                Console.WriteLine("La resta es: {0}", a - b);
            }
            else
            {
                Console.WriteLine("No estas suscrito a los eventos");
            }
        }
    }


    public class SuscriptorCalculadoraVirutal
    {
        EditorCalculadora editor;
        private readonly int A;
        private readonly int B;

        public void EjemploEventHandler()
        {
            Console.WriteLine("Se va a imprimir el resultado:");
        }

        public void EjemploEventHandler2()
        {
            Console.WriteLine("este es nuestro segundo evento.");
        }

        public SuscriptorCalculadoraVirutal(int a, int b)
        {
            editor = new EditorCalculadora();
            A = a;
            B = b;
            editor.ejemploEvento += EjemploEventHandler; ///para dar de alta al evento
            editor.ejemploEvento -= EjemploEventHandler2; ///para dar de baja al evento
        }

        public void ResultadoSuma()
        {
            editor.sumar(A, B);
        }

        public void ResultadoResta()
        {
            editor.Restar(A, B);
        }

    }
}
