using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int dif, a, b, c, d;

            Console.WriteLine("Descobrindo a diferença");
            Console.Write("Primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Quarto valor: ");
            d = int.Parse(Console.ReadLine());

            dif = a * b - c * d;

            Console.WriteLine("Diferença igual = "+dif);
        }
    }
}
