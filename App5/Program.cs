using System;

namespace SumaRestaMultiplicacionDivision
{
    class SumaRestaMultiplicacionDivision
    {
        static void Main(string[] args)
        {
            int a, b, operacion, resultado_final;
            Console.Write("Ingresa el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona el valor de operacion.");
            Console.WriteLine("\t1.- Suma");
            Console.WriteLine("\t2.- Resta");
            Console.WriteLine("\t3.- Multiplicaci\u00F3n");
            Console.WriteLine("\t4.- Divisi\u00F3n");
            Console.Write("\t: ");
            do
            {
                operacion = int.Parse(Console.ReadLine());
                if (operacion < 1 || operacion > 5)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (operacion < 1 || operacion > 5);
            resultado_final = 0;
            if (operacion == 1)
            {
                resultado_final = a + b;
                Console.WriteLine("Suma");
            }
            if (operacion == 2)
            {
                resultado_final = a - b;
                Console.WriteLine("Resta");
            }
            if (operacion == 3)
            {
                resultado_final = a * b;
                Console.WriteLine("Multiplicaci\u00F3n");
            }
            {
                resultado_final = a / b;
                Console.WriteLine("Divisi\u00F3n");
            }
            {
            Console.WriteLine("Valor de resultado final: " + resultado_final);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}