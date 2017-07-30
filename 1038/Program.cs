using System;
using System.Globalization;
namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            double preco, total;

            string[] pedido = Console.ReadLine().Split(' ');
            cod = int.Parse(pedido[0]);
            qtd = int.Parse(pedido[1]);
            preco = 0;
            if (cod == 1)
            {
                preco = 4.00;
            }
            else if (cod == 2)
            {
                preco = 4.50;
            }
            else if (cod == 3)
            {
                preco = 5.00;
            }
            else if (cod == 4)
            {
                preco = 2.00;
            }
            else if (cod == 5)
            {
                preco = 1.50;
            }
            total = preco * qtd;
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}
