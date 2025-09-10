using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveSeries
{
    internal class Program
    {
        static void PrintSeries(int current, int n)
        {
            if (current > n) 
                return;

            Console.Write(current + "\t");
            PrintSeries(current * 2, n); 
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the last number (n): ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSeries:");
            PrintSeries(2, n);
        }
    }
}
