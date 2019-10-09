using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main()
        {
            //zadnica1();
            //zadnica2();
            //zadnica3();
            //zadnica4();
            //zadnica5();
            //zadnica6();
            //for7();
            //for8();
            //for9();
            //for10();
            //for11();
            //for12();
            //for13();
            //for14();
            //for15();
            // for16();
            for20();

        }
        static void zadnica1()
        {
            int n = 3, k = 1;
            for (int i = 0; i < n; i++)

                Console.WriteLine(k);
        }
        static void zadnica2()
        {
            int a = 1,b = 5,n = b;
            for (int i = a; i <= b; i++)

                Console.WriteLine(i);
            Console.WriteLine(n);
        }
        static void zadnica3()
        {
            int a = 2, b = 5, n = b;
            for (int i = b - 1; i > a; i--)

                Console.WriteLine(i);
            Console.WriteLine(n);
        }
        static void zadnica4()
        {
            int cena = 2;

            for (int i = 1; i <= 10; i++)
                Console.WriteLine(cena * i);
        }
        static void zadnica5()
        {
            int cena = 10;

            for (double i = 0.1; i <= 1; i += 0.1)
                Console.WriteLine(cena * i);
        }
        static void zadnica6()
        {
            int cena = 10;

            for (double i = 1.2; i <= 2; i += 0.2)
                Console.WriteLine(cena * i);
        }
        static void for7()
        {
            int a = 2, b = 4, s = 0;
            for (int i = a; i <= b; i++)
                s += i;
            Console.WriteLine(s);
        }
        static void for8()
        {
            int a = 2,b = 4, s = 1;
            for (int i = a; i <= b; i++)
                s *= i;
            Console.WriteLine(s);
        }
        static void for9()
        {
            int a = 2,b = 4,s = 1;
            for (int i = a; i <= b; i++)
                s *= i * i;
            Console.WriteLine(s);
        }
        static void for10()
        {
            int n = 5;
            double s = 0;
            for (double i = 1; i <= n; i++)
                s += 1 / i;
            Console.WriteLine(s);
        }
        static void for11()
        {
            int n = 2;
            double s = 0;

            for (int i = 1; i <= n; i++)
                s += Math.Pow(n + i, 2);
            Console.WriteLine(s);
        }
        static void for12()
        {
            int n = 3;
            double proisvedenie = 1, helpa = 1.1;
            for (double i = 1; i <= n; i++)
                proisvedenie *=helpa;
                helpa += 0.1;
            Console.WriteLine(proisvedenie);
        }
        static void for13()
        {
            int n = 3;
            double proisvedenie = 1, helpa = 1.1;
            for (double i = 1; i <= n; i++)
                proisvedenie *= helpa;
            helpa += 0.1;
            Console.WriteLine(proisvedenie);
        }
        static void for14()
        {
            int n = 5;
            int s = 0;
            for (int i = 1; i <= 2 * n - 1; i+=2)
                s += i++;
            Console.WriteLine(s);

        }
        static void for15()
        {
            float a = 6;   
            int n = 2;
            float power = 1;
            for (float i = 1; i <= n; i++)
            
                power *= a;
           
                Console.WriteLine(power);
        }
        static void for16()
        {
            float a = 6, power = 1;
            int n = 2;
             

            for (float i = 1; i <= n; i++)
            { 
                power *= a;
            Console.WriteLine(power);
            }
        }
        static void for17()
        {
            float a = 6, sum = 1, powerA = 1;
            int n = 2;
            for (float i = 1; i <= n; i++)
            {
                powerA *= a;
                sum += powerA;
                
            }
            Console.WriteLine(sum);
        }
        static void for18()
        {
            float a = 6, sum = 1, powerA = 1;
            int n = 2;
            for (float i = 1; i <= n; i++)
            {
                powerA *= -a;
                sum += powerA;

            }

        }
            static void for19()
            {
                double powerA = 1;
                int n = 5;
                for (float i = 1; i <= n; i++)
                    powerA *= i;
                Console.WriteLine(powerA);
            }
        static void for20()
        {
            int n = 2;
            float n1 = 1, sum = 0;
            int i;

            for (i = 1; i <= n; ++i)
            {
                n1 *= (float)i;
                sum += n1;
            }
        }

        static void for21()
        {
            int n = 2;
            float n1 = 1, rez = 1;
            int i;


            for (i = 1; i <= n; ++i)
            {
                n1 *= (float)i;
                rez += 1 / n1;
            }
        }

    }   
}
