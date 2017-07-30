using System;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVendas, salarioTotal;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFixo = (totalVendas * 0.15) + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + salarioFixo.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}
