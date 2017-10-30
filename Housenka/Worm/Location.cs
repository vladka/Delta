namespace Worm
{   
    

    public struct Location
    {
        public readonly int X;
        public readonly int Y;
        public readonly string Value;

        /// <summary>
        /// poloha na obrazovce a hodnota znaku
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="value"></param>
        public Location(int x, int y,string value)
        {
            X = x;
            Y = y;
            Value = value;
        }
    }
}