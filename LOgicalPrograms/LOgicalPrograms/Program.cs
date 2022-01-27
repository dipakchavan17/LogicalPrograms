using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOgicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programs");
            FibonacciSeries1 fibonacciSeries1 = new FibonacciSeries1();
            fibonacciSeries1.fibonacciSeries();
            Console.ReadLine();
        }
    }
}
