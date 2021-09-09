using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectGame
{    
    public static class MainPage
    {
        public static int Points { get; set; } = 0;
        private static int corentChoice = 0;
        public static void Start()
        {
            Console.SetWindowSize(41, 15);
            Console.CursorVisible = false;
            DrowBoard();
            while (true)
            {
                try
                {
                    ClickKey();
                }
                catch (EndGameException)
                {
                    return;
                }
            }
        }
        private static void DrowBoard()
        {
            for (int i = 1; i < 40; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("_");
                Console.SetCursorPosition(i, 14);
                Console.Write("-");
            }          
            for (int i = 1; i < 15; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                Console.SetCursorPosition(40, i);
                Console.Write("|");
            }
            Console.SetCursorPosition(16, 7);
            Console.Write($"points: {Points}");
            Console.SetCursorPosition(15, 10);
            Console.Write("Start Game");
            Console.SetCursorPosition(18, 12);
            Console.Write("Exit");
        }
        private static void ClickKey()
        {
            if (Console.KeyAvailable)
            {
                Console.CursorVisible = false;
                var key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        ClickDown(corentChoice);
                        if (corentChoice == 0)
                            corentChoice = 1;
                        else if (corentChoice == 1)
                            corentChoice = 2;
                        break;
                    case ConsoleKey.UpArrow:
                        ClickUp(corentChoice);
                        if (corentChoice == 0)
                            corentChoice = 2;
                        else if (corentChoice == 2)
                            corentChoice = 1;
                        break;                    
                    case ConsoleKey.Enter:
                        ClickEnter(corentChoice);
                        break;
                }
            }
            else
            {
                Thread.Sleep(10);
            }
        }
        private static void ClickDown(int corentChoice)
        {
            if(corentChoice == 0)
            {
                for(int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(15 + i, 10);
                    Console.Write(" ");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 10);
                Console.Write("Start Game");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (corentChoice == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(18 + i, 12);
                    Console.Write(" ");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(18, 12);
                Console.Write("Exit");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(15 + i, 10);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(15, 10);
                Console.Write("Start Game");
            }
        }
        private static void ClickUp(int corentChoice)
        {
            if (corentChoice == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(18 + i, 12);
                    Console.Write(" ");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(18, 12);
                Console.Write("Exit");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (corentChoice == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(15 + i, 10);
                    Console.Write(" ");
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 10);
                Console.Write("Start Game");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(18 + i, 12);
                    Console.Write(" ");
                }
                Console.SetCursorPosition(18, 12);
                Console.Write("Exit");
            }
        }
        private static void ClickEnter(int corentChoice)
        {
            if (corentChoice == 1)
            {
                Clear();
                Game.Play();
                Console.SetWindowSize(41, 15);
                DrowBoard();
            }
            else if (corentChoice == 2)
                throw new EndGameException();
        }
        private static void Clear()
        {
            Console.Clear();
        }
    }
}
