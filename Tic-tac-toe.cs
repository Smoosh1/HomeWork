using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossesAndNulls
{
    class Program
    {

        static int height = 3, width = 3, AmountOfPlayers = 2, StepCounter = AmountOfPlayers;
        static char player1 = 'X';
        static char player2 = 'O';
        static char empty = '_';
        static char[,] field = new char[height, width];

        public static void Main()
        {
            Generation();
            while (!IsWin1() && !IsWin2() && !DrawSituation())
            {

                Input();

                Draw();
            }
            WhoIsWinner();


        }
        static void WhoIsWinner()
        {
            if (IsWin1() == true)
            {
                Console.WriteLine("X WINS!");
            }
            if (IsWin2() == true)
            {
                Console.WriteLine("O WIN!");
            }
            if (DrawSituation() == true)
            {
                Console.WriteLine("Draw, meh");
            }
        }


        static void Generation()
        {
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    field[i, j] = empty;
                }
            }
        }



        static void Draw()
        {
            Console.Clear();

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Input()
        {
            
           
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        if (field[0, 0] == empty)
                        {
                            field[0, 0] = player1;
                        }
                        break;
                    case ConsoleKey.D2:
                        if (field[0, 1] == empty)
                        {
                            field[0, 1] = player1;
                        }
                        break;
                    case ConsoleKey.D3:
                        if (field[0, 2] == empty)
                        {
                            field[0, 2] = player1;
                        }
                        break;
                    case ConsoleKey.D4:
                        if (field[1, 0] == empty)
                        {
                            field[1, 0] = player1;
                        }
                        break;
                    case ConsoleKey.D5:
                        if (field[1, 1] == empty)
                        {
                            field[1, 1] = player1;
                        }
                        break;
                    case ConsoleKey.D6:
                        if (field[1, 2] == empty)
                        {
                            field[1, 2] = player1;
                        }
                        break;
                    case ConsoleKey.D7:
                        if (field[2, 0] == empty)
                        {
                            field[2, 0] = player1;
                        }
                        break;

                    case ConsoleKey.D8:
                        if (field[2, 1] == empty)
                        {
                            field[2, 1] = player1;
                        }
                        break;
                    case ConsoleKey.D9:
                        if (field[2, 2] == empty)
                        {
                            field[2, 2] = player1;
                        }
                        break;
              
                
                

            
                case ConsoleKey.NumPad1:
                    if (field[0, 0] == empty)
                    {
                        field[0, 0] = player2;
                    }
                    break;
                case ConsoleKey.NumPad2:
                    if (field[0, 1] == empty)
                    {
                        field[0, 1] = player2;
                    }
                    break;
                case ConsoleKey.NumPad3:
                    if (field[0, 2] == empty)
                    {
                        field[0, 2] = player2;
                    }
                    break;
                case ConsoleKey.NumPad4:
                    if (field[1, 0] == empty)
                    {
                        field[1, 0] = player2;
                    }
                    break;
                case ConsoleKey.NumPad5:
                    if (field[1, 1] == empty)
                    {
                        field[1, 1] = player2;
                    }
                    break;
                case ConsoleKey.NumPad6:
                    if (field[1, 2] == empty)
                    {
                        field[1, 2] = player2;
                    }
                    break;
                case ConsoleKey.NumPad7:
                    if (field[2, 0] == empty)
                    {
                        field[2, 0] = player2;
                    }
                    break;

                case ConsoleKey.NumPad8:
                    if (field[2, 1] == empty)
                    {
                        field[2, 1] = player2;
                    }
                    break;
                case ConsoleKey.NumPad9:
                    if (field[2, 2] == empty)
                    {
                        field[2, 2] = player2;
                    }
                    break;

                
            }
        }


        static bool IsWin1()
        {
            char[] res = new char[3];
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    res[j] = field[i, j];
                }
                if (res[0] == player1 && res[1] == player1 && res[2] == player1)
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    res[j] = field[j, i];
                }
                if (res[0] == player1 && res[1] == player1 && res[2] == player1)
                {
                    return true;
                }
            }
            if (field[0, 0] == player1 && field[1, 1] == player1 && field[2, 2] == player1 || field[0, 2] == player1 && field[1, 1] == player1 && field[2, 0] == player1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool IsWin2()
        {
            char[] res = new char[3];
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    res[j] = field[i, j];
                }
                if (res[0] == player2 && res[1] == player2 && res[2] == player2)
                {
                    return true;
                }
            }
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    res[j] = field[j, i];
                }
                if (res[0] == player2 && res[1] == player2 && res[2] == player2)
                {
                    return true;
                }
            }
            if (field[0, 0] == player2 && field[1, 1] == player2 && field[2, 2] == player2 || field[0, 2] == player2 && field[1, 1] == player2 && field[2, 0] == player2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool DrawSituation()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] != empty)
                    {
                        count += 1;
                    }
                }
            }
            if (count == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}