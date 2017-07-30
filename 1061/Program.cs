using System;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicial, horaInicial, minutosInicial, segundosInicial,
                diaFinal, horaFinal, minutosFinal, segundosFinal,
                totalSegundosInicio, totalSegundosFim, totalSegundosInicial, totalSegundosFinal, totalGeral,
                dias, horas, minutos, segundos;



            string[] dia1 = Console.ReadLine().Split(' ');
            diaInicial = int.Parse(dia1[1]);
            string[] hora1 = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(hora1[0]);
            minutosInicial = int.Parse(hora1[2]);
            segundosInicial = int.Parse(hora1[4]);

            string[] dia2 = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(dia2[1]);
            string[] hora2 = Console.ReadLine().Split(' ');
            horaFinal = int.Parse(hora2[0]);
            minutosFinal = int.Parse(hora2[2]);
            segundosFinal = int.Parse(hora2[4]);


            totalSegundosInicio = 24 * 3600 * diaInicial;
            totalSegundosFim = 24 * 3600 * diaFinal;


            totalSegundosInicial = (horaInicial * 3600) + (minutosInicial * 60) + segundosInicial;
            totalSegundosFinal = (horaFinal * 3600) + (minutosFinal * 60) + segundosFinal;

            totalGeral = (totalSegundosFim + totalSegundosFinal) - (totalSegundosInicio + totalSegundosInicial);

            dias = totalGeral / 86400;
            horas = totalGeral % 86400 / 3600;
            minutos = totalGeral % 86400 % 3600 / 60;
            segundos = totalGeral % 86400 % 3600 % 60;

            Console.WriteLine(dias + " dia(s)");
            Console.WriteLine(horas + " hora(s)");
            Console.WriteLine(minutos + " minuto(s)");
            Console.WriteLine(segundos + " segundo(s)");
            //Console.ReadLine();
        }
    }
}
