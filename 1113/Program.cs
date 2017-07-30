using System;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] num = Console.ReadLine().Split(' ');
            X = int.Parse(num[0]);
            Y = int.Parse(num[1]);

            while ( X != Y)
            {
                if(X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else
                {
                    Console.WriteLine("Crescente");
                }
                num = Console.ReadLine().Split(' ');
                X = int.Parse(num[0]);
                Y = int.Parse(num[1]);
            }
            //Console.ReadLine();


        }
    }
}
