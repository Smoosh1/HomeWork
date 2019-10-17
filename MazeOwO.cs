using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOne
{
    class GameOne
    {
        static Random random = new Random();
        static char wall = '#', EmptyCell = ' ', finish = 'F', mainCharacter = '@';
        static int width = 21, height = 11, frequency, dx = 0, dy = 0, newX, newY;
        static int FX = random.Next(1, height);
        static int FY = random.Next(1, width);
        static int chararactersX = random.Next(1, height);
        static int charactersY = random.Next(1, width);
        static char[,] Map = new char[height, width];

        static void Main()
        {
            
            Console.WriteLine("If you want to know who is boss of this gym, you should find da wa ye");
            Console.WriteLine();
            Init();
            while (!IsEndGame())
            {
                Draw();
                Input();
                Logic();
            }
            Console.WriteLine();
            Console.WriteLine("You are boss of this gym");
        }


        static void Init()
        {
            Console.Write("frequency =");
            frequency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j < width; j++)
                {
                    Map[i, j] = Generate();
                }
            }
            Map[FX, FY] = finish;
            Map[chararactersX, charactersY] = mainCharacter;
        }


        static char Generate()
        {
            int num = random.Next(0, 100);
            char symb = (num < frequency ? wall : EmptyCell);
            return symb;
        }


        static void Draw()
        {
            Console.Clear();
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(Map[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Input()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:               
                    dy = -1;
                    break;
                case ConsoleKey.S:                
                    dy = 1;
                    break;
                case ConsoleKey.A:               
                    dx = -1;
                    break;
                case ConsoleKey.D:          
                    dx = 1;
                    break;
            }
        }


        static void Logic()
        {
            TryMove();
            IsEndGame();
        }


        static void TryMove()
        {
            newX = chararactersX + dy;
            newY = charactersY + dx;
            if (IsWalkable())
            {
                Goto();
            }
            dx = 0;
            dy = 0;
        }


        static bool IsWalkable()
        {
            if ((newX < height) && (newY < width) && (newX > 0) && (newY > 0))
            {
                if (Map[newX, newY] != wall)
                    return true;
            }
            return false;
        }


        static void Goto()
        {
            Map[chararactersX, charactersY] = EmptyCell;
            chararactersX = newX;
            charactersY = newY;
            Map[newX, newY] = mainCharacter;
        }


        static bool IsEndGame()
        {
            if (Map[chararactersX, charactersY] == Map[FX, FY]) return true;
            return false;
        }


    }
}