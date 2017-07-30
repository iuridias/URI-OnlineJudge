using System;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] numeros = Console.ReadLine().Split(' ');
            A = int.Parse(numeros[0]);
            B = int.Parse(numeros[1]);
            C = int.Parse(numeros[2]);
            D = int.Parse(numeros[3]);

            if (B>C && D>A && (C+D) > (A+B) && C>0 && C>0 && (A % 2) == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
           //Console.ReadLine();
        }
    }
}
