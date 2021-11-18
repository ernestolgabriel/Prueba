using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
        	Class1 clase0 = new Class1();
            Console.Title = "Ejercicio de prueba";
            char caracter = '\0';
            Console.WriteLine("Desea continuar No (n)");
            caracter = (char) Console.Read();
            Class2 clase = new Class2();

            while(caracter != 'n')
            {
                Console.Write("\nDesea continuar Si (s) No (n)");
                caracter = (char)Console.Read();
               Console.ReadLine();
            }

            Console.WriteLine("Pulsa cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
