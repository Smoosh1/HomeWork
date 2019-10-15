using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            series26();
        }


        static void Series1()
        {
            int series = 10, sum = 0;
            for (int i = 0; i <= series; i++)
                sum += i;
            Console.WriteLine(sum);
        }
        static void Series9()
        {
            int N = 5;

            for (int i = 0; i <= N; i++)
                if (i % 2 != 0)
                    Console.WriteLine(i);
        }
        static void series20()
        {
            int n = 5;
            int i;
            for (i = 1; i <= n; ++i)
            {
                if (i < i - 1)
                    Console.WriteLine(i);
            }
            Console.WriteLine(i);
        }
        static void series26()
        {
            int n = 3, k = 5,i;
            for(i = 0; i<=n;i++)
            {
                Console.WriteLine(Math.Pow(i, k));
            }
        }
        static void series30()
        {
            int k = 3, n = 5;

            int i, j, a, sum;
            for (i = 1; i <= k; ++i, sum = 0)
            {
                for (j = 1; j <= n; ++j)
                {

                }
                Console.WriteLine();

            }
        }
    }
}
