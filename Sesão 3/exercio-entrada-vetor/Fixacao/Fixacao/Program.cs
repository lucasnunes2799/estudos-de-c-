using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("{0}, {1}, {2}", c, a, b);
        }
    }
}
