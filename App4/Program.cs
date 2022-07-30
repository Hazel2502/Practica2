using System;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Su nombre es: {1} y tiene {0} años de edad ", edad, name);
        }
    }
}
