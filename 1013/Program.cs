using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB, maiorABC;
            string[] numeros;

            numeros = Console.ReadLine().Split(' ');

            A = int.Parse(numeros[0]);
            B = int.Parse(numeros[1]);
            C = int.Parse(numeros[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;
            Console.WriteLine(maiorABC + " eh o maior");
            //Console.ReadLine();

        }
    }
}
