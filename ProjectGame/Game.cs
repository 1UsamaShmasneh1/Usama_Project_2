using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectGame
{
    public static class Game
    {
        public static int points = MainPage.Points;
        public static int Round { get; set; } = 1;
        public static int Failed { get; set; } = 0;
        const char ball = '*';
        private static int width;
        private static int height;
        public static bool[,] pixels;
        private static Random random = new Random();
        private static int drowCount;
        public static void Play()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(83, 32);
            pixels = new bool[82, 32];
            drowCount = random.Next(3, 7);
            DrowPoard();
            RandomDrowShape(drowCount);
            RandomPositionBall(out width, out height);
            while (true)
            {
                try
                {
                    ClickKey();
                    CheckWinning();

                }
                catch(OutOfRangeConsoleException)
                {
                    drowCount++;
                    Failed++;
                    Clear();
                    DrowPoard();
                    RandomDrowShape(drowCount);
                    RandomPositionBall(out width, out height);
                }
                catch (FilledPositionException)
                {
                    drowCount++;
                    Failed++;
                    Clear();
                    DrowPoard();
                    RandomDrowShape(drowCount);
                    RandomPositionBall(out width, out height);
                }
                catch (AfterWinningException)
                {
                    Clear();
                    DrowPoard();
                    RandomDrowShape(drowCount);
                    RandomPositionBall(out width, out height);
                }
                catch (GameOverException)
                {
                    Clear();
                    return;
                }
                catch (EndGameException)
                {
                    Clear();
                    return;
                }
            }
        }
        private static void DrowPoard()
        {
            for(int i = 1; i < 82; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("_");
                pixels[i, 0] = true;
                Console.SetCursorPosition(i, 4);
                Console.Write("_");
                pixels[i, 0] = true;
                Console.SetCursorPosition(i, 31);
                Console.Write("-");
                pixels[i, 0] = true;
            }
            for (int i = 1; i < 32; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("|");
                pixels[i, 0] = true;
                Console.SetCursorPosition(82, i);
                Console.Write("|");
                pixels[i, 0] = true;
            }
            Console.SetCursorPosition(7, 3);
            Console.Write($"points: {points}");
            Console.SetCursorPosition(25, 3);
            Console.Write($"round: {Round}");
            Console.SetCursorPosition(45, 3);
            Console.Write($"failed: {Failed}");
            Console.SetCursorPosition(67, 3);
            Console.Write($"shapes: {drowCount}");
        }
        private static void RandomDrowShape(int drowCount)
        {
            CubeShape cubeShape = new CubeShape();
            Rectangel rectangel = new Rectangel();
            Triangular triangular = new Triangular();
            LineShape lineShape = new LineShape();
            int randomChoice;
            for (int i = 0; i < drowCount; i++)
            {
                randomChoice = random.Next(4);
                switch (randomChoice)
                {
                    case 0:
                        cubeShape.ShapeDrow();
                        break;
                    case 1:
                        rectangel.ShapeDrow();
                        break;
                    case 2:
                        triangular.ShapeDrow();
                        break;
                    case 3:
                        lineShape.ShapeDrow();
                        break;
                }
            }
        }
        private static void RandomPositionBall(out int width, out int height)
        {
            Random randomWidth = new Random();
            Random randomHeight = new Random();
            do
            {
                width = randomWidth.Next(1, 81);
                height = randomHeight.Next(5, 30);
            }
            while (pixels[width, height]);
            pixels[width, height] = true;
            Console.SetCursorPosition(width, height);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ball);
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
                        if (height < 30)
                        {
                            if(!pixels[width, height + 1])
                            {
                                ChangeBallColorToBlue(ball, width, height);
                                height++;
                                pixels[width, height] = true;
                            }
                            else
                                throw new FilledPositionException();
                        }
                        else
                        {
                            throw new OutOfRangeConsoleException();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (height > 5)
                        {
                            if (!pixels[width, height - 1])
                            {
                                ChangeBallColorToBlue(ball, width, height);
                                height--;                                
                                pixels[width, height] = true;
                            }
                            else
                                throw new FilledPositionException();
                        }
                        else
                        {
                            throw new OutOfRangeConsoleException();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (width > 1)
                        {
                            if (!pixels[width - 1, height])
                            {
                                ChangeBallColorToBlue(ball, width, height);
                                width--;
                                pixels[width, height] = true;
                            }
                            else
                                throw new FilledPositionException();
                        }
                        else
                        {
                            throw new OutOfRangeConsoleException();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if(width < 81)
                        {
                            if (!pixels[width + 1, height])
                            {
                                ChangeBallColorToBlue(ball, width, height);
                                width++;                                
                                pixels[width, height] = true;
                            }
                            else
                                throw new FilledPositionException();
                        }
                        else
                        {
                            throw new OutOfRangeConsoleException();
                        }
                        break;
                    case ConsoleKey.Escape:
                        throw new EndGameException();
                }                
                MoveBall(ball, width, height);
            }
            else
            {
                Thread.Sleep(10);
            }
        }
        private static void ChangeBallColorToBlue(char ball, int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(width, height);
            Console.Write(ball);
        }
        private static void MoveBall(char ball, int width, int height)
        {   
            Console.SetCursorPosition(width, height);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ball);   
        }        
        private static void Clear()
        {
            Console.Clear();
            for (int i = 0; i < pixels.GetLength(0); i++)
            {
                for (int j = 0; j < pixels.GetLength(1); j++)
                {
                    pixels[i, j] = false;
                }
            }
        }
        private static void CheckWinning()
        {
            if(drowCount == 15 || Failed == 30)
            {
                throw new GameOverException();
            }
            for (int i = 5; i < 31; i++)
            {
                for(int j = 1; j < 82; j++)
                {
                    if (!pixels[j, i])
                        return;
                }
            }
            points++;
            Round++;
            throw new AfterWinningException();
        }
    }
}
