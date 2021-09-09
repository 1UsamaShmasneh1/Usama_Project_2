using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    public class CubeShape : Shape
    {
        private int cubeHeight;
        private int width;
        private int height;
        public override void ShapeDrow()
        {
            for (int k = 0; k < 11; k++)
            {
                try
                {
                    GetIdices();
                    CheckValidLocation();
                    for (int i = 0; i < cubeHeight; i++)
                    {
                        for (int j = 0; j < cubeHeight; j++)
                        {
                            Game.pixels[width + i, height + j] = true;
                            Console.SetCursorPosition(width + i, height + j);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("o");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    return;
                }
                catch (NotValidLocationException)
                {

                }
            }
        }
        protected override void GetIdices()
        {
            Random random = new Random();
            cubeHeight = random.Next(3, 11);
            do
            {
                width = random.Next(2 , 81);
                height = random.Next(7, 30);
            }
            while ((width + cubeHeight) >= 81 || (height + cubeHeight) >= 30);
        }
        protected override void CheckValidLocation()
        {
            for (int i = 0; i < cubeHeight; i++)
            {
                for (int j = 0; j < cubeHeight; j++)
                {
                    if (Game.pixels[width + i, height + j])
                        throw new NotValidLocationException();
                }
            }
        }
    }
}
