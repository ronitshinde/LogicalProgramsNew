using System;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            int n, i, sum;
            int mn, mx;

            Console.WriteLine("Find the numbers within a given number of range");
            Console.WriteLine("Input the starting range or number");

            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of numbers");

            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The perfect number within the given range : ");

            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = (sum + i);
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0}", n);
            }
        }
    }
}   