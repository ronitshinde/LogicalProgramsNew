using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fibonanci Series\n2.Perfect Number\n3.Prime Number");
            Console.WriteLine("Enter the option");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonanciSeries series = new FibonanciSeries();
                    series.DisplayFibSeries();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
