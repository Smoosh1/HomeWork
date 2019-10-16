using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {


        static char wall = '#', nullCell = ' ', character = '@', finish = 'F';

        static int width = 10, height = 5, Frequency = 20, dx = 0, dy = 0, newX, newY;

        static Random random = new Random();
        static int Fx = random.Next(), Fy = random.Next(), CharacterX = random.Next(), CharacterY = random.Next();
        static char[,] field = new char[width, height];


        static void Main(string[] args)
        {
            Draw();
            
            /* while(CheckEndGame())
               {
                   Draw();
                   Input();
                   Logyc();
               }*/
        }
        public static char Draw()
        {
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    Console.Write(field[j, i]);
                }
            Console.WriteLine();
        }
        public static void GenerateMap()
        {
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    //          = Random(0,100);
                }
            }
        }
        static void Init()
        {
            Console.WriteLine("Frequency=");
            Frequency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < width; i++)
            {
                for (int j = 1; j < height; j++)
                {
                    field[i, j] = Draw();
                }
            }
            field[Fx, Fx] = finish;
            field[CharacterX, CharacterY] = character;
        }

    }
}
