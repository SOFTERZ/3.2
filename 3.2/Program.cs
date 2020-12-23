using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число m: ");
                int m = int.Parse(Console.ReadLine());
                Random rand = new Random();
                int[] values = new int[10];
                int n = rand.Next(10);
                values[n] = rand.Next(1, 1001);
                double result;
                result = Math.Pow(n, 2) / Math.Pow(m, 2);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
