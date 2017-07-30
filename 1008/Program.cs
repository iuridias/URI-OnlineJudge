using System;
using System.Globalization;
namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, workHours;
            double forHour, salary;

            number = int.Parse(Console.ReadLine());
            workHours = int.Parse(Console.ReadLine());
            forHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = workHours * forHour;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();
        }
    }
}
