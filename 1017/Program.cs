using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoViagem, velocidadeMedia, distanciaPercorrida;
            double quantidadeLitros;

            tempoViagem = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoViagem * velocidadeMedia;
            quantidadeLitros = distanciaPercorrida / 12.0;

            Console.WriteLine(quantidadeLitros.ToString("F3", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}
