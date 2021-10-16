using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare dois valores para serem somados");
            Console.Write("Primeiro valor: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            int b = int.Parse(Console.ReadLine());

            a += b;

            Console.WriteLine("Resultado da Soma é igual: {0}", a);
        }
    }
}
