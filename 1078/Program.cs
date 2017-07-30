using System;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, soma;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i<=10; i++)
            {
                soma = i * N;
                Console.WriteLine(i + " x " + N + " = " + soma);
            }
            Console.ReadLine();

        }
    }
}
