using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgicalPrograms
{
    internal class SquareRoot
    {
        public void sqrtNewtonsMethod()
        {
            Console.WriteLine("Enter the value of c :");
            double c = Convert.ToDouble(Console.ReadLine());
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
        }

    }
}
