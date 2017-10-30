using System;
using System.ComponentModel.DataAnnotations;

namespace Worm
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Direction direction = Direction.Right;
            var worm = new Worm(new Location(10,10,"0"));
            
            while(true)
            {
                
                while (!Console.KeyAvailable)
                {
                    worm.Move(direction);
                }
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow: direction = Direction.Left;break;
                    case ConsoleKey.RightArrow: direction = Direction.Right; break;
                    case ConsoleKey.DownArrow: direction = Direction.Down; break;
                    case ConsoleKey.UpArrow: direction = Direction.Up; break;

                    case ConsoleKey.End: direction = Direction.UpRight; break;
                }

            } 
            

            
        }
    }
}