using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main()
        {
            // for9();
           // for14();
        }
        static void for9()
        {
            int a = 2;
            int b = 5;
            int sum = 0;
            for (int i = a; i <= b; i++)
                sum += i * i;
            Console.WriteLine(sum);
        }
        static void for10()
        {
            int n = 4;
            double znachenie = 0;
            for (double i = 1; i <= n; i++)           
                znachenie += 1 / i;
               
             Console.WriteLine(znachenie);            
        }
        static void for14()
        {
            int n = 2;
            double Kvadrat = 0;
            for (int i = 1; i <= n * n; i+=2*n-1)
            {
               //Kvadrat += 2 * n - 1;
    
                Console.WriteLine(i);
            }
        }

        static void for15()
        {
            double A = 5;
            int n = 2;
            double znachenie = 0;
            for (double i = A; i <= Math.Pow(A,n); i*=n)
                znachenie += A;

            Console.WriteLine(znachenie);
        }


    }
}
