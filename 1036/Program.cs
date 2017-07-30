﻿using System;
using System.Globalization;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, R1, R2, delta;

            string[] num = Console.ReadLine().Split(' ');
            A = double.Parse(num[0], CultureInfo.InvariantCulture);
            B = double.Parse(num[1], CultureInfo.InvariantCulture);
            C = double.Parse(num[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B,2) - 4 * A * C;

            if (delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
