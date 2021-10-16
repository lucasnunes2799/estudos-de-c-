using System;
using System.Globalization;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int Code1, Amount1, Code2, Amount2;
            double Value1, Value2, Sum;

            Console.WriteLine("Venda de produtos");
            Console.WriteLine("Declare o codigo, quantidade e valor unitario: ");
            string[] p1 = Console.ReadLine().Split(' ');
            Code1 = int.Parse(p1[0]);
            Amount1 = int.Parse(p1[1]);
            Value1 = Double.Parse(p1[2],CultureInfo.InvariantCulture);
            Console.WriteLine("Declare o codigo, quantidade e valor unitario: ");
            string[] p2 = Console.ReadLine().Split(' ');
            Code2 = int.Parse(p2[0]);
            Amount2 = int.Parse(p2[1]);
            Value2 = Double.Parse(p2[2],CultureInfo.InvariantCulture);

            Sum = (Amount1 * Value1) + (Amount2 * Value2);


            Console.WriteLine("VALOR A PAGAR: " + Sum.ToString("F2",CultureInfo.InvariantCulture));






        }
    }
}
