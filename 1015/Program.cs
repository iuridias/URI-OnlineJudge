using System;
using System.Globalization;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distancia;
            string[] pontos1, pontos2;

            pontos1 = Console.ReadLine().Split(' ');
            pontos2 = Console.ReadLine().Split(' ');

            x1 = double.Parse(pontos1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(pontos1[1], CultureInfo.InvariantCulture);
            x2 = double.Parse(pontos2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(pontos2[1], CultureInfo.InvariantCulture);

            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}
