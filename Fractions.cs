using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct InputData
    {
        public void DataOfFractions()
        {
            bool denomeratorsMoreThenZero = false;
            int numerator1 = int.Parse(Console.ReadLine());
            int denominator1 = int.Parse(Console.ReadLine());
            int numerator2 = int.Parse(Console.ReadLine());
            int denominator2 = int.Parse(Console.ReadLine());
        }
    } 

    class Program  
    {

        public void Main()
        {
            Check();
            Start();
        }
        
       public void Check()
        {           
            do
            {
                Console.WriteLine("Denominator can`t be equalized 0, please input correct data");
                denomeratorsMoreThenZero = true;
            }
            while (denominator1 == 0 && denominator2 == 0);
        }
        public void Start()
        {
            Fraction first = new Fraction();
            Fraction second = new Fraction();
            first.numerator = numerator1;
            first.denominator = denominator1;
            first.Write();

            Console.Write(" + ");

            second.numerator = numerator2;
            second.denominator = denominator2;
            second.Write();

            Console.Write(" = ");

            (first + second).Write();
        }
        
            

    }
    





        struct Fraction
        {
            public int numerator;
            public int denominator;
            public void Write()
            {
                Console.Write(numerator + "/" + denominator);
            }


            public static Fraction operator +(Fraction first, Fraction second)
            {
                Fraction geatheredFraction;

                if (first.denominator != second.denominator)
                {
                    geatheredFraction.denominator = MCM(first.denominator, second.denominator);

                    geatheredFraction.numerator = first.numerator * MCM(first.denominator, second.denominator) / first.denominator + second.numerator * MCM(first.denominator, second.denominator) / second.denominator;

                }
                else 
                {
                    geatheredFraction.denominator = first.denominator;
                    geatheredFraction.numerator = first.numerator + second.numerator;
                }

                int AbbreviatedFraction = MCD(geatheredFraction.numerator, geatheredFraction.denominator);
                geatheredFraction.numerator /= AbbreviatedFraction;
                geatheredFraction.denominator /= AbbreviatedFraction;
                return geatheredFraction;

            }
            static int MCM(int Num1, int Num2)
            {
                return (Num1 * Num2) / MCD(Num1, Num2);
            }
            static int MCD(int a, int b)
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a %= b;
                    }
                    else b %= a;
                }
                return a + b;
            }

        }
        
    }


