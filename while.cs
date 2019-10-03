using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main()
        {
            while1();
            //while4();
        }
        static void while1()
        {
            int A = 4;
            int B = 2;
            while (A >= B)
            {
                A -=B;
                Console.WriteLine(A);

            }
            

        }
        static void while4()
        {
            int n = 9;
            while (n % 3 == 0)
                n /= 3;
            Console.WriteLine(n == 1 ? "True" : "False");

        }
        static void while5()
        {
            int n = 4;
            int s = 0;
            while (n % 2 == 0)
                s += n /= 2;
            Console.WriteLine(n == 1 ? s++ : s);

        }
    }


}