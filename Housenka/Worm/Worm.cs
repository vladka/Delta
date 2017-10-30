using System;
using System.Collections.Generic;
using System.Threading;

namespace Worm
{
    /// <summary>
    /// consolova housenka s pouzitim fronty
    /// </summary>
    public class Worm
    {
        private  int _n;
        /// <summary>
        /// Fronta pro drzeni poloh telicka
        /// </summary>
        private readonly Queue<Location> _body = new Queue<Location>();

        public Worm(Location initLocation)
        {
            CurrentLocation = initLocation;
            Length = 20;
        }
        
        private Location CurrentLocation { get; set; }
        public  int Length { get; set; }

        public void Move(Direction direction)
        {
            CurrentLocation = CurrentLocation.ChangeByDirection(direction, (++_n%10)+"");
            _body.Enqueue(CurrentLocation);
            
            Console.SetCursorPosition(CurrentLocation.X,CurrentLocation.Y);
            Console.Write(CurrentLocation.Value);
            Thread.Sleep(50);

            if (_body.Count > Length)
            {
                var last = _body.Dequeue();
                Console.SetCursorPosition(last.X, last.Y);
                Console.Write(" ");
                Thread.Sleep(50);
            }

        }
    }
}