using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numPeca1, codPeca2, numPeca2;
            double precoPeca1, precoPeca2, totalPagar;

            string[] peca1 = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(peca1[0]);
            numPeca1 = int.Parse(peca1[1]);
            precoPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            codPeca2 = int.Parse(peca2[0]);
            numPeca2 = int.Parse(peca2[1]);
            precoPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            totalPagar = ((numPeca1 * precoPeca1) + (numPeca2 * precoPeca2));

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}
