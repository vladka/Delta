namespace Worm
{
    public class Direction
    {
        public readonly int DeltaX;
        public readonly int DeltaY;

        /// <summary>
        /// privatni konstruktor pro zakazani vytvareni jinych nez pripravenych instanci
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        private Direction(int deltaX, int deltaY)
        {
            DeltaX = deltaX;
            DeltaY = deltaY;
        }

        //pripravene instance:
        public static readonly Direction Up = new Direction(0,-1);
        public static readonly Direction Down = new Direction(0, 1);
        public static readonly Direction Left = new Direction(-1,0);
        public static readonly Direction Right = new Direction(1,0);

        public static readonly Direction UpRight = new Direction(1, -1);
    }
}