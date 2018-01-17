using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Character
    {
        public int X;
        public int Y;
        public int sizeX = 90;
        public int sizeY = 35;

        public void Snake()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine("#");
        }

        public void Movement()
        {
            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (Y <= 0)
                            Y = 0;
                        else
                            Y--;

                        UpdatePosition();
                        break;
                    case ConsoleKey.RightArrow:
                        if (X >= sizeX)
                            X = sizeX;
                        else
                            X++;

                        UpdatePosition();
                        break;
                    case ConsoleKey.DownArrow:
                        if (Y >= sizeY)
                            Y = sizeY;
                        else
                            Y++;

                        UpdatePosition();
                        break;
                    case ConsoleKey.LeftArrow:
                        if (X <= 0)
                            X = 0;
                        else
                            X--;

                        UpdatePosition();
                        break;
                }
            }
            
        }

        public void UpdatePosition()
        {
            Console.Clear();
            if (CheckPosition() == true)
                Console.SetCursorPosition(X, Y);

            Console.Write("#");
            
        }

        public bool CheckPosition()
        {
            if (X < 0)
            {
                Console.SetCursorPosition(0, Y);
                return false;
            }

            else if (X >= Console.WindowWidth)
            {
                Console.SetCursorPosition(sizeX, Y);
                return false;
            }

            else if (Y < 0)
            {
                Console.SetCursorPosition(X, 0);
                return false;
            }

            else if (Y >= Console.WindowHeight)
            {
                Console.SetCursorPosition(X, sizeY);
            }

            return true;
        }
    
    }
}
