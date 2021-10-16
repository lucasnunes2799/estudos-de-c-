using System;
using System.Globalization;

namespace fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double Area, Raio, PI = 3.14159;

            Console.WriteLine("Calcular area do circulo");
            Console.Write("Declare o valor do Raio: ");
            Raio = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = PI * Raio * Raio;

            Console.WriteLine("A="+Area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
