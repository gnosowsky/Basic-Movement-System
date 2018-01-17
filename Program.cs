using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            Food food = new Food();
            Console.CursorVisible = false;

            Console.SetWindowSize(character.sizeX, character.sizeY);

            character.Snake();
            food.Position();
            character.Movement();

            Console.ReadKey();
        }
    }
}
