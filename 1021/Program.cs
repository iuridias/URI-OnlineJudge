using System;
using System.Globalization;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas100, notas50, notas20, notas10, notas5, notas2;
            double valorTotal, moedas1, moedas050, moedas025, moedas010, moedas05, moedas01, centavos;
            
            valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notas100 = (int) valorTotal / 100;
            notas50 = (int) valorTotal % 100 / 50;
            notas20 = (int) valorTotal % 100 % 50 / 20;
            notas10 = (int) valorTotal % 100 % 50 % 20 / 10;
            notas5 = (int)valorTotal % 100 % 50 % 20 % 10 / 5;
            notas2 = (int) valorTotal % 100 % 50 % 20 % 10 % 5 / 2;

            centavos = valorTotal % 100 % 50 % 20 % 10 % 5 % 2;
            moedas1 = centavos / 1.0;
            moedas050 = centavos % 1.0 / 0.5;
            moedas025 = centavos % 1.0 % 0.5 / 0.25;
            moedas010 = centavos % 1.0 % 0.5 % 0.25 / 0.1;
            moedas05 = centavos % 1.0 % 0.5 % 0.25 % 0.1 / 0.05;
            moedas01 = centavos % 1.0 % 0.5 % 0.25 % 0.1 % 0.05 / 0.01;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)moedas1 + " moeda(s) de R$ 1,00");
            Console.WriteLine((int)moedas050 + " moeda(s) de R$ 0,50");
            Console.WriteLine((int)moedas025 + " moeda(s) de R$ 0,25");
            Console.WriteLine((int)moedas010 + " moeda(s) de R$ 0,10");
            Console.WriteLine((int)moedas05 + " moeda(s) de R$ 0,05");
            Console.WriteLine((int)moedas01 + " moeda(s) de R$ 0,01");
            Console.ReadLine();

        }
    }
}
