using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Fibonanci Series \n2.Perfect Number \n3.Prime Number \n4.Reverse Number");
            Console.WriteLine("Enter the option");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonanciSeries series = new FibonanciSeries();
                    series.DisplayFibSeries();
                    Console.ReadLine();
                    break;
                case 2:
                    PerfectNumber number = new PerfectNumber();
                    number.Perfect();
                    Console.ReadLine();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeNum();
                    Console.ReadLine();
                    break;
                    case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.ReverseNum();
                    Console.ReadLine();
                    break; 

            }
        }
    }
}
