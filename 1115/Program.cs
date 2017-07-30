using System;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            string[] num = Console.ReadLine().Split(' ');
            X = int.Parse(num[0]);
            Y = int.Parse(num[1]);

            while ( X != 0 || Y != 0)
            {
                if ( X == 0 || Y == 0)
                {
                    X = 0;
                    Y = 0;
                }
                else
                {
                    if (X > 0 && Y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else if (X > 0 && Y < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                    else if (X < 0 && Y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                    else
                    {
                        Console.WriteLine("segundo");
                    }
                    num = Console.ReadLine().Split(' ');
                    X = int.Parse(num[0]);
                    Y = int.Parse(num[1]);
                }
            }
            //Console.ReadLine();

        }
    }
}
