using System;

namespace ProjectGame
{
    public class Triangular: Shape
    {
        private int triangelWidth;
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
                    for (int i = (triangelWidth + 1) / 2; i > 0; i--)
                    {
                        for (int j = 0; j < triangelWidth; j++)
                        {
                            Game.pixels[width + j, height] = true;
                            Console.SetCursorPosition(width + j, height);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("#");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        triangelWidth -= 2;
                        width++;
                        height--;
                    }
                    return;
                }
                catch(NotValidLocationException)
                {

                }
            }
        }
        protected override void GetIdices()
        {
            Random random = new Random();
            do
            {
                triangelWidth = random.Next(3, 10);
            }
            while (triangelWidth % 2 == 0);
            do
            {
                width = random.Next(2, 81);
                height = random.Next(7, 30);
            }
            while ((width + triangelWidth) >= 81 || (height - triangelWidth / 2 + 1) <= 5);
        }
        protected override void CheckValidLocation()
        {
            int triangelWidth1 = triangelWidth;
            int width1 = width;
            int height1 = height;
            for (int i = (triangelWidth1 + 1) / 2; i > 0; i--)
            {
                for (int j = 0; j < triangelWidth1; j++)
                {
                    if(Game.pixels[width1 + j, height1])
                        throw new NotValidLocationException();                    
                }
                triangelWidth1 -= 2;
                width1++;
                height1--;
            }
        }
    }
}
