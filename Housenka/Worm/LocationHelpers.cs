namespace Worm
{
    //ukazka extension metody
    //trida i metoda musi byt staticka


    public static class LocationHelpers
    {
        public static Location ChangeByDirection(this/*!!!*/ Location curentLocation, Direction direction, string value)
        {
            return new Location(curentLocation.X+direction.DeltaX, curentLocation.Y+direction.DeltaY, value);
        }
    }
}