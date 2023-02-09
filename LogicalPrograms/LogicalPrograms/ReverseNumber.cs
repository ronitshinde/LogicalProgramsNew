using System;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void ReverseNum()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed the Number : " + reverse);
        }
    }
}

