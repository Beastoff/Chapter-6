using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] payRate = { 6.00, 7.35, 8.12, 12.45, 22.22 };

            for (int i = 0; i < payRate.Length; i++)
            {
                if (payRate[i] > 11)
                {
                    Console.WriteLine(payRate[i].ToString("C"));
                }
            }
        }
    }
}
