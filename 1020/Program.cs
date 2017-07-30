using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int diasTotal, dias, meses, anos;

            diasTotal = int.Parse(Console.ReadLine());

            anos = diasTotal / 365;
            meses = diasTotal % 365 / 30;
            dias = diasTotal % 365 % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            //Console.ReadLine();
        }
    }
}
