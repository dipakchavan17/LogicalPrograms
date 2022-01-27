using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgicalPrograms
{
    internal class PrimeNum1
    {
        public void primeNumber()
        {
            Console.WriteLine("Enter Strating point : ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending point : ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime number between " + start + " and " + end + " are : ");
            int count;
            for (int i = start; i <= end; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count = count + 1;
                }
                if (count == 2)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
