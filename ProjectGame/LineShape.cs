using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame
{
    public class LineShape : Shape
    {
        private int LineLenght;
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
                    for (int i = 0; i < LineLenght; i++)
                    {
                        Game.pixels[width + i, height] = true;
                        Console.SetCursorPosition(width + i, height);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("=");
                        Console.ForegroundColor = ConsoleColor.White;
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
            LineLenght = random.Next(2, 11);
            do
            {
                width = random.Next(2, 81);
                height = random.Next(7, 30);
            }
            while ((width + LineLenght) >= 81 || (height + LineLenght) >= 30);
        }
        protected override void CheckValidLocation()
        {
            for (int i = 0; i < LineLenght; i++)
            {
                if (Game.pixels[width + i, height])
                    throw new NotValidLocationException();
            }
        }

    }
}
