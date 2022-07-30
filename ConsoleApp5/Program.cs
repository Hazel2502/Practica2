using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingrese un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingrese otro numero: ");
            int num2 = int.Parse(Console.ReadLine());
            var suma = num1 + num2;
            double resta = num1 - num2;
            double multiplicacion = num1 * num2;
            double decimal division = num1 / num2;
            System.Console.WriteLine("El resultado de las operaciones son  suma: {0}, resta: {1}, multiplicacion: {2}, division: {3} , ", suma, resta , multiplicacion , division);
           
        }
    }
}
