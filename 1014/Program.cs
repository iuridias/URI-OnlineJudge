using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            //Console.ReadLine();
        }
    }
}
