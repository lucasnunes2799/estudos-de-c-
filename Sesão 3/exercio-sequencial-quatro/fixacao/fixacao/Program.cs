using System;
using System.Globalization;

namespace fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int Code, Hours;
            double Value;

            Console.WriteLine("Calcular o salario do funcionario");
            Console.Write("Declare o codigo do funcionario: ");
            Code = int.Parse(Console.ReadLine());
            Console.Write("Declare a quantidade de horas trabalhadas: ");
            Hours = int.Parse(Console.ReadLine());
            Console.Write("Declare o valor da hora: ");
            Value = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Value *= Hours;

            Console.WriteLine("Code: " + Code);
            Console.WriteLine("Salary: U$" + Value.ToString("F2",CultureInfo.InvariantCulture));


        }
    }
}
