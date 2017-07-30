using System;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            soma = 0;
            Y = Y + 1;
            for (int i = 0; Y < X; i++)
            {
                if ((Y % 2) != 0) 
                {
                    soma = soma + Y;
                }
                Y = Y + 1;
            }
            Console.WriteLine(soma);
            Console.ReadLine();

        }
    }
}
