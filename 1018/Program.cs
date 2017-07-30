using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, notas100, notas50, notas20, notas10, notas5, notas2, notas1;

            N = int.Parse(Console.ReadLine());

            notas100 = N / 100;
            notas50 = N % 100 / 50;
            notas20 = N % 100 % 50 / 20;
            notas10 = N % 100 % 50 % 20 / 10;
            notas5 = N % 100 % 50 % 20 % 10 / 5;
            notas2 = N % 100 % 50 % 20 % 10 % 5 / 2;
            notas1 = N % 100 % 50 % 20 % 10 % 5 % 2 / 1;

            Console.WriteLine(N);
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
            //Console.ReadLine();
        }
    }
}
