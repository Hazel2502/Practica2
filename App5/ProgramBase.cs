namespace App5
{
    internal class ProgramBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            int num2 = int.Parse(Console.ReadLine());
            int v = num1 + num2;
            var suma = v;
            int x = num1 - num2;
            var resta = x;
            Console.WriteLine("La suma de los numeros es: {0} la resta de los numeros es: {1} ", suma, resta);
        }
    }
}